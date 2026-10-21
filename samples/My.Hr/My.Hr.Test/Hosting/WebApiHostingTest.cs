using Beef.AspNetCore.WebApi;
using Beef.Test.NUnit;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace My.Hr.Test.Hosting
{
    [TestFixture, NonParallelizable]
    public class WebApiHostingTest
    {
        [TestCase(false, false, "file")]
        [TestCase(false, true, "environment")]
        [TestCase(true, true, "command-line")]
        public async Task GenericHostPreservesConfigurationAndServiceLifetime(bool useCommandLine, bool useEnvironment, string expected)
        {
            var directory = Path.Combine(Path.GetTempPath(), "Beef.Hosting." + Guid.NewGuid().ToString("N"));
            Directory.CreateDirectory(directory);
            var file = Path.Combine(directory, "appsettings.json");
            var prefix = "BeefHosting" + Guid.NewGuid().ToString("N");
            var variable = prefix + "_HostingProbe";
            File.WriteAllText(file, "{\"HostingProbe\":\"file\"}");
            Environment.SetEnvironmentVariable(variable, useEnvironment ? "environment" : null);

            try
            {
                var args = useCommandLine ? new[] { "--HostingProbe=command-line" } : Array.Empty<string>();
                using var host = WebApiStartup.CreateHost<HostingStartup>(args, prefix)
                    .UseContentRoot(directory)
                    .UseEnvironment(Environments.Development)
                    .ConfigureWebHost(webBuilder => webBuilder.UseTestServer())
                    .Build();

                await host.StartAsync();
                var probe = host.Services.GetRequiredService<LifetimeProbe>();
                Assert.IsTrue(probe.Started);
                Assert.AreEqual(Environments.Development, host.Services.GetRequiredService<IWebHostEnvironment>().EnvironmentName);
                using var client = host.GetTestClient();
                Assert.AreEqual(expected, await client.GetStringAsync("/"));

                await host.StopAsync();
                Assert.IsTrue(probe.Stopped);
            }
            finally
            {
                Environment.SetEnvironmentVariable(variable, null);
                File.Delete(file);
                Directory.Delete(directory);
            }
        }

        [Test]
        public async Task AgentTestServerStartsStopsAndDisposesHostedServices()
        {
            LifetimeProbe probe;
            var config = new ConfigurationBuilder().AddInMemoryCollection(new Dictionary<string, string?>
            {
                ["HostingProbe"] = "test-server"
            }).Build();

            using (var tester = AgentTester.CreateServer<HostingStartup>(
                environment: Environments.Development, config: config, configureLocalRefData: false))
            {
                probe = tester.TestServer.Services.GetRequiredService<LifetimeProbe>();
                Assert.IsTrue(probe.Started);
                using var client = tester.GetHttpClient();
                Assert.AreEqual("test-server", await client.GetStringAsync("/"));
            }

            Assert.IsTrue(probe.Stopped);
            Assert.IsTrue(probe.Disposed);
        }

        [TestCase("/health")]
        [TestCase("/swagger/v1/swagger.json")]
        public async Task ApplicationFactoryUsesGenericHostAndServesApi(string path)
        {
            using var factory = new WebApplicationFactory<Api.Startup>()
                .WithWebHostBuilder(webBuilder => webBuilder
                    .UseContentRoot(AppContext.BaseDirectory)
                    .UseEnvironment(Environments.Development));
            using var client = factory.CreateClient();
            using var response = await client.GetAsync(path);

            Assert.IsTrue(response.IsSuccessStatusCode);
            Assert.AreSame(factory.Services, factory.Services.GetRequiredService<IHost>().Services);
            Assert.AreEqual("25", factory.Services.GetRequiredService<IConfiguration>()["BeefDefaultPageSize"]);
        }

        public class HostingStartup
        {
            private readonly IConfiguration _config;

            public HostingStartup(IConfiguration config) => _config = config;

            public void ConfigureServices(IServiceCollection services)
            {
                services.AddSingleton<LifetimeProbe>();
                services.AddHostedService(sp => sp.GetRequiredService<LifetimeProbe>());
            }

            public void Configure(IApplicationBuilder app) => app.Run(context =>
                context.Response.WriteAsync(_config["HostingProbe"] ?? "missing"));
        }

        public class LifetimeProbe : IHostedService, IDisposable
        {
            public bool Started { get; private set; }
            public bool Stopped { get; private set; }
            public bool Disposed { get; private set; }

            public Task StartAsync(CancellationToken cancellationToken)
            {
                Started = true;
                return Task.CompletedTask;
            }

            public Task StopAsync(CancellationToken cancellationToken)
            {
                Stopped = true;
                return Task.CompletedTask;
            }

            public void Dispose() => Disposed = true;
        }
    }
}

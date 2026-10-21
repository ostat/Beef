using Beef.AspNetCore.WebApi;
using Microsoft.Extensions.Hosting;

namespace Beef.Demo.Api
{
    public static class Program
    {
        /// <summary>
        /// Main startup.
        /// </summary>
        /// <param name="args">The startup arguments.</param>
        public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

        /// <summary>
        /// Creates the <see cref="IHostBuilder"/> using the <i>Beef</i> <see cref="WebApiStartup"/> capability to create the host with the underlying configuration probing.
        /// </summary>
        /// <param name="args">The startup arguments.</param>
        /// <returns>The <see cref="IHostBuilder"/>.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) => WebApiStartup.CreateHost<Startup>(args, "Beef");
    }
}
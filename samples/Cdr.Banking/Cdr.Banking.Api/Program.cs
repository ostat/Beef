using Beef.AspNetCore.WebApi;
using Microsoft.Extensions.Hosting;

namespace Cdr.Banking.Api
{
    /// <summary>
    /// The <b>WebAPI</b> host.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Main startup.
        /// </summary>
        /// <param name="args">The startup arguments.</param>
        public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

        /// <summary>
        /// Creates the <see cref="IHostBuilder"/>.
        /// </summary>
        /// <param name="args">The startup arguments.</param>
        /// <returns>The <see cref="IHostBuilder"/>.</returns>
        public static IHostBuilder CreateHostBuilder(string[] args) => WebApiStartup.CreateHost<Startup>(args, "Banking");
    }
}
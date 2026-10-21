# Beef.AspNetCore.WebApi

[![NuGet version](https://badge.fury.io/nu/Beef.AspNetCore.WebApi.svg)](https://badge.fury.io/nu/Beef.AspNetCore.WebApi)

The primary goal of this assembly is to support the [Service Interface](../../docs/Layer-ServiceInterface.md) layer capabilities.

Use the generic host to run an API with its existing `Startup` class:

```csharp
using Beef.AspNetCore.WebApi;
using Microsoft.Extensions.Hosting;

public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

public static IHostBuilder CreateHostBuilder(string[] args) =>
    WebApiStartup.CreateHost<Startup>(args, "Hr");
```

`CreateHost` uses `Host.CreateDefaultBuilder` and `ConfigureWebHostDefaults`, retaining Kestrel, IIS integration, and Beef's configuration loading. The prefix argument still selects application environment variables, such as `Hr_ConnectionStrings__Database`. Existing controllers, routes, middleware, and `Startup.ConfigureServices`/`Configure` methods continue to define the API.

The generic host manages the web server and hosted services through one dependency injection container and application lifetime. Startup waits for hosted services to start; shutdown stops them and disposes their services. Configure `HostOptions.ShutdownTimeout` through `ConfigureServices` if the deployment requires a specific shutdown budget. In the Development environment, service registrations and scopes are also validated, which can expose existing dependency injection errors during startup.

`CreateHostBuilder` returns `IHostBuilder`; move any additional web-specific customization into `.ConfigureWebHost(webBuilder => ...)`. `WebApplicationFactory` discovers this entry point automatically. `WebApiStartup.BuildHost<Startup>(args, "Hr")` is also available when no additional builder configuration is needed.

The older `CreateWebHost` and `BuildWebHost` methods remain available for existing callers, with obsolete warnings pointing to the generic-host replacements. The new helpers support both .NET 8 and .NET 10. The migrated samples and solution template use the generic host; the template uses the existing configuration helper directly to remain compatible with its pinned Beef package.

Microsoft documents the reason for this migration in [WebHostBuilder, IWebHost, and WebHost are obsolete](https://learn.microsoft.com/en-us/aspnet/core/breaking-changes/10/webhostbuilder-deprecated?view=aspnetcore-10.0).

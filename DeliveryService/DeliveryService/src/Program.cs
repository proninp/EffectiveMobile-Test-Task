using DeliveryService.Options;
using DeliveryService.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;

var environment = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Production";

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile(Path.Combine("Configuration", "appsettings.json"), optional: true, reloadOnChange: true)
    .AddJsonFile(Path.Combine("Configuration", $"appsettings.{environment}.json"), optional: true, reloadOnChange: true)
    .Build();

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(configuration)
    .CreateLogger();

var serviceCollection = new ServiceCollection()
    .Configure<AppSettings>(configuration.GetSection(nameof(AppSettings)));

serviceCollection
    .AddSingleton<IConfiguration>(configuration)
    .AddSingleton(Log.Logger)
    .AddSingleton<AppService>();


var serviceProvider = serviceCollection.BuildServiceProvider();

var appService = serviceProvider.GetRequiredService<AppService>();
appService.Run(args);
using DeliveryService.Services;
using DeliveryService.Services.Abstractions;
using DeliveryService.Data;
using DeliveryService.Options;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Serilog;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;


var environment = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Production";

var configuration = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile(Path.Combine("Configuration", "appsettings.json"), optional: true, reloadOnChange: true)
    .AddJsonFile(Path.Combine("Configuration", $"appsettings.{environment}.json"), optional: true, reloadOnChange: true)
    .Build();

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(configuration)
    .CreateLogger();

var serviceCollection = new ServiceCollection();
serviceCollection.Configure<DbOptions>(configuration.GetSection(nameof(DbOptions)));

serviceCollection.AddDbContext<AppDbContext>();

serviceCollection
    .AddSingleton<IConfiguration>(configuration)
    .AddSingleton<AppService>()
    .AddTransient<IArgumentsValidator, ArgumentsValidator>()
    .AddTransient<IArgumentParser, ArgumentParser>()
    .AddTransient<IOrderFilterProvider, DeliveryHandler>();

var serviceProvider = serviceCollection.BuildServiceProvider();

var appService = serviceProvider.GetRequiredService<AppService>();
await appService.RunAsync(args);
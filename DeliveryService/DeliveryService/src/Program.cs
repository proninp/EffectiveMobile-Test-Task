using DeliveryService.Services;
using DeliveryService.Services.Abstractions;
using DeliveryService.src.Services;
using DeliveryService.src.Util;
using Microsoft.Extensions.DependencyInjection;
using Serilog;


var configuration = AppConfiguration.BuildConfiguration();

Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(configuration)
    .CreateLogger();

var serviceCollection = new ServiceCollection()
    .AddDbOptions(configuration)
    .AddSingleton(Log.Logger)
    .AddSingleton<AppService>()
    .AddTransient<IArgumentsValidator, ArgumentsValidator>()
    .AddTransient<IArgumentParser, ArgumentParser>()
    .AddTransient<IOrderFilterProvider, DeliveryHandler>()
    .AddTransient<IOrderInformer, ConsoleInformer>();


var serviceProvider = serviceCollection.BuildServiceProvider();

var appService = serviceProvider.GetRequiredService<AppService>();
await appService.RunAsync(args);
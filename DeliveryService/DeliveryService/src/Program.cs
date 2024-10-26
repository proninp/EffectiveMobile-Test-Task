﻿using DeliveryService.Options;
using DeliveryService.Services;
using DeliveryService.Services.Abstractions;
using DeliveryService.src.Data;
using DeliveryService.src.Services;
using DeliveryService.src.Services.Abstractions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;


var host = Host.CreateDefaultBuilder(args)
    .ConfigureAppConfiguration((context, config) =>
    {
        var environment = context.HostingEnvironment;

        config.SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile(Path.Combine("Configuration", "appsettings.json"), optional: false, reloadOnChange: true)
            .AddJsonFile(Path.Combine("Configuration", $"appsettings.{environment.EnvironmentName}.json"), optional: false, reloadOnChange: true);
    })
    .UseSerilog((context, services, configuration) =>
    {
        configuration.ReadFrom.Configuration(context.Configuration);
    })
    .ConfigureServices((context, services) =>
    {
        services.Configure<AppSettings>(context.Configuration.GetSection(nameof(AppSettings)))
            .AddDbContext<AppDbContext>()
            .AddSingleton<AppService>()
            .AddTransient<IArgumentsValidator, ArgumentsValidator>()
            .AddTransient<IOrderHandler, OrderHandler>();
    })
    .Build();

var appService = host.Services.GetRequiredService<AppService>();
appService.Run(args);
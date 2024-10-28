using DeliveryService.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DeliveryService.Util;
public static class AppConfiguration
{
    public static IConfiguration BuildConfiguration()
    {
        var environment = Environment.GetEnvironmentVariable("DOTNET_ENVIRONMENT") ?? "Development";
        return new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile(Path.Combine("Configuration", $"appsettings.{environment}.json"), optional: true, reloadOnChange: true)
            .Build();
    }

    public static DbContextOptions<AppDbContext> CreateDbContextOptions(IConfiguration configuration)
    {
        var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        optionsBuilder.UseNpgsql(GetDbConnection(configuration));
        return optionsBuilder.Options;
    }

    public static IServiceCollection AddDbOptions(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseNpgsql(GetDbConnection(configuration));
        });
        return services;
    }

    private static string? GetDbConnection(IConfiguration configuration) =>
        configuration["DbOptions:ConnectionString"];
}

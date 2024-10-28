using DeliveryService.Data;
using DeliveryService.src.Util;
using Microsoft.EntityFrameworkCore.Design;

namespace DeliveryService.src.Data;
public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
{
    public AppDbContext CreateDbContext(string[] args)
    {
        var configuration = AppConfiguration.BuildConfiguration();
        var dbContextOptions = AppConfiguration.CreateDbContextOptions(configuration);
        return new AppDbContext(dbContextOptions);
    }
}

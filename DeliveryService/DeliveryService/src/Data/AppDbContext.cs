using DeliveryService.Models;
using DeliveryService.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DeliveryService.src.Data;
public class AppDbContext : DbContext
{
    private readonly AppSettings _options;

    public AppDbContext(IOptions<AppSettings> options)
    {
        _options = options.Value;
    }

    public DbSet<Order> Orders { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseNpgsql(_options.DbConnectionString);
        }
    }

}

using DeliveryService.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliveryService.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Order> Orders { get; set; }

    public DbSet<District> Districts { get; set; }

    public DbSet<Delivery> Deliveries { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Order>()
            .Property(o => o.DeliveryTime)
            .HasColumnType("timestamp without time zone");

        modelBuilder.Entity<Delivery>()
            .Property(d => d.LastDeliveryFilterTime)
            .HasColumnType("timestamp without time zone");
    }
}

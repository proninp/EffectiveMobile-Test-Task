using DeliveryService.Models;
using DeliveryService.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace DeliveryService.Data;
public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }

    public DbSet<Order> Orders { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<Delivery> Deliveries { get; set; }
}

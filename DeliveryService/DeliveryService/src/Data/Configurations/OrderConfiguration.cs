using DeliveryService.Models;
using DeliveryService.src.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeliveryService.src.Data.Configurations;
public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder
            .Property(o => o.DeliveryTime)
            .HasColumnType("timestamp without time zone");

        builder.HasData(TestDataInitializer.GetOrderSeeds());
    }
}
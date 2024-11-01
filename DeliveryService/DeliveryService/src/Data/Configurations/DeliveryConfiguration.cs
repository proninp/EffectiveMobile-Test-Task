using DeliveryService.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeliveryService.src.Data.Configurations;
public class DeliveryConfiguration : IEntityTypeConfiguration<Delivery>
{
    public void Configure(EntityTypeBuilder<Delivery> builder)
    {
        builder
            .Property(d => d.LastDeliveryFilterTime)
            .HasColumnType("timestamp without time zone");
    }
}

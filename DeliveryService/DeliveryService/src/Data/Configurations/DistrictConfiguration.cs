using DeliveryService.Models;
using DeliveryService.src.Util;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DeliveryService.src.Data.Configurations;
public class DistrictConfiguration : IEntityTypeConfiguration<District>
{
    public void Configure(EntityTypeBuilder<District> builder)
    {
        builder.HasData(TestDataInitializer.GetDistrictSeeds());
    }
}

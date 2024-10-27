using System.ComponentModel.DataAnnotations;

namespace DeliveryService.Models;
public sealed class Order
{
    [Key]
    public long Id { get; set; }

    public double Weight { get; set; }

    public long DistrictId { get; set; }

    public DateTime DeliveryTime { get; set; }

    public override string? ToString()
    {
        return $"{nameof(Id)}: {Id}; {nameof(Weight)}: {Weight}; {nameof(DistrictId)}: {DistrictId}; {nameof(DeliveryTime)}: {DeliveryTime}";
    }
}

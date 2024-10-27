namespace DeliveryService.Models;
public sealed class OrderFilter
{
    public long? DistrictId { get; set; }

    public DateTime? DeliveryTime { get; set; }
}

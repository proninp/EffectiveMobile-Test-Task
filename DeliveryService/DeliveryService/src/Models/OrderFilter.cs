namespace DeliveryService.src.Models;
public class OrderFilter
{
    public long? OrderId { get; set; }

    public double? Weight { get; set; }

    public long? DistrictId { get; set; }

    public DateTime? DeliveryTime { get; set; }
}

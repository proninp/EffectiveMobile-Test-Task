namespace DeliveryService.Models;
public class Order
{
    public Guid Id { get; set; }

    public long OrderId { get; set; }

    public double Weight { get; set; }

    public long DistrictId { get; set; }

    public DateTime DeliveryTime { get; set; }
}

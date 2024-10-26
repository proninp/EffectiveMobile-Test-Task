using System.ComponentModel.DataAnnotations;

namespace DeliveryService.Models;
public class Order
{
    [Key]
    public Guid Id { get; set; }

    public long OrderId { get; set; }

    public double Weight { get; set; }

    public long DistrictId { get; set; }

    public DateTime DeliveryTime { get; set; }
}

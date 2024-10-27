using System.ComponentModel.DataAnnotations;

namespace DeliveryService.Models;
public sealed class Delivery
{
    [Key]
    public long Id { get; set; }

    public long OrderId { get; set; }

    public long DistrictId { get; set; }

    public DateTime LastDeliveryFilterTime { get; set; }
}

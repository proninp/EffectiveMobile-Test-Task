using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryService.Models;
public sealed class Delivery
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public long OrderId { get; set; }

    public long DistrictId { get; set; }

    public DateTime LastDeliveryFilterTime { get; set; }
    
    public Order Order { get; set; }

    public District District { get; set; }
}

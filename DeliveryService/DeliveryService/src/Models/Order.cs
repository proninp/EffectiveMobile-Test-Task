using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryService.Models;
public sealed class Order
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public double Weight { get; set; }

    public long DistrictId { get; set; }

    public DateTime DeliveryTime { get; set; }

    public District District { get; set; }

    public override string? ToString()
    {
        return $"{nameof(Id)}: {Id}; {nameof(Weight)}: {Weight}; {nameof(DistrictId)}: {DistrictId}; {nameof(DeliveryTime)}: {DeliveryTime}";
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeliveryService.Models;
public sealed class District
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public string Name { get; set; }

    public ICollection<Order> Orders { get; set; }

    public ICollection<Delivery> Deliveries { get; set; }
}

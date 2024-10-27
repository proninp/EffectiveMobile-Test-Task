using System.ComponentModel.DataAnnotations;

namespace DeliveryService.Models;
public sealed class District
{
    [Key]
    public long Id { get; set; }

    public string Name { get; set; }
}

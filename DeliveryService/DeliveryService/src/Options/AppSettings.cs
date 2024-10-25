using System.ComponentModel.DataAnnotations;

namespace DeliveryService.Options;
public class AppSettings
{
    [Required]
    public required string DbConnectionString { get; set; }
}

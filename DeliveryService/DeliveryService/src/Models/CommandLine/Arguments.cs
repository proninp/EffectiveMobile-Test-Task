using CommandLine;

namespace DeliveryService.Models.CommandLine;
public class Arguments
{
    [Option('d', "districtId", HelpText = "Иденификатор района")]
    public long? DistrictId { get; set; } = null;

    [Option('t', "deliveryTime", HelpText = "Время доставки заказа - в формате: yyyy-MM-dd HH:mm:ss")]
    public string? DeliveryTimeString { get; set; }
    
    public DateTime? DeliveryTime { get; set;}
}

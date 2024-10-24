using CommandLine;

namespace DeliveryService.src.Models.CommandLine;
public class Arguments
{
    [Option('o', "orderId", HelpText = "Иденификатор заказа")]
    public long OrderId { get; set; }

    [Option('w', "weight", HelpText = "Вес в килограммах")]
    public double Weight { get; set; }

    [Option('d', "districtId", HelpText = "Иденификатор района")]
    public long DistrictId { get; set; }

    [Option('t', "deliveryTime", HelpText = "Время доставки заказа - в формате: yyyy-MM-dd HH:mm:ss")]
    public DateTime DeliveryTime { get; set; }
}

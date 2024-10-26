﻿using CommandLine;

namespace DeliveryService.Models.CommandLine;
public class Arguments
{
    [Option('o', "orderId", HelpText = "Иденификатор заказа")]
    public long? OrderId { get; set; } = null;

    [Option('w', "weight", HelpText = "Вес в килограммах")]
    public double? Weight { get; set; } = null;

    [Option('d', "districtId", HelpText = "Иденификатор района")]
    public long? DistrictId { get; set; } = null;

    [Option('t', "deliveryTime", HelpText = "Время доставки заказа - в формате: yyyy-MM-dd HH:mm:ss")]
    public DateTime? DeliveryTime { get; set; } = null;
}
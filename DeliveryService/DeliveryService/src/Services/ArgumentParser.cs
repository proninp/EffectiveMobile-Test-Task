using DeliveryService.Models.CommandLine;
using DeliveryService.Models;
using DeliveryService.Services.Abstractions;

namespace DeliveryService.Services;
public sealed class ArgumentParser : IArgumentParser
{
    public OrderFilter ParseArgumentsToFilter(Arguments args)
    {
        return new OrderFilter
        {
            DistrictId = args.DistrictId,
            DeliveryTime = args.DeliveryTime,
        };
    }
}

using DeliveryService.Models.CommandLine;
using DeliveryService.Models;

namespace DeliveryService.Services.Abstractions;
public interface IArgumentParser
{
    OrderFilter ParseArgumentsToFilter(Arguments args);
}

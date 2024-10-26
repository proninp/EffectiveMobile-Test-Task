using DeliveryService.Models.CommandLine;
using DeliveryService.src.Models;

namespace DeliveryService.src.Services.Abstractions;
public interface IArgumentParser
{
    OrderFilter ParseArgumentsToFilter(Arguments args);
}

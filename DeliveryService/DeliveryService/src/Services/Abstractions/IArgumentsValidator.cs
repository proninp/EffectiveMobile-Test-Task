using CommandLine;
using DeliveryService.Models.CommandLine;

namespace DeliveryService.Services.Abstractions;
public interface IArgumentsValidator
{
    void Validate(Arguments arguments);

    void HandleErrors(IEnumerable<Error> errors);
}

using CommandLine;
using DeliveryService.Models.CommandLine;
using DeliveryService.src.Services.Abstractions;
using System.Text;

namespace DeliveryService.src.Services;
public sealed class ArgumentsValidator : IArgumentsValidator
{
    public void HandleErrors(IEnumerable<Error> errors)
    {
        if (errors.IsHelp() || errors.IsVersion())
            Environment.Exit(0);

        var sbErrors = new StringBuilder("Ошибка в аргументах командной строки.")
            .AppendLine()
            .Append(string.Join(Environment.NewLine, errors.Select(e => $"{e.Tag}: {e}")));

        throw new ArgumentException(sbErrors.ToString());
    }

    public void Validate(Arguments arguments)
    {
        if (arguments is null)
            throw new ArgumentNullException(nameof(arguments), "Аргументы не могут быть null.");

        var isFilterEmpty = arguments.OrderId is null &&
                            arguments.Weight is null &&
                            arguments.DistrictId is null &&
                            arguments.DeliveryTime is null;

        if (isFilterEmpty)
            throw new ArgumentException("Не заданы аргументы фильтрации. Укажите хотя бы одно значение для фильтрации.");
    }
}

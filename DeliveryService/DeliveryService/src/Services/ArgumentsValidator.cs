using CommandLine;
using DeliveryService.Models.CommandLine;
using DeliveryService.Services.Abstractions;
using System.Globalization;
using System.Text;

namespace DeliveryService.Services;
public sealed class ArgumentsValidator : IArgumentsValidator
{
    private const string DateFormat = "yyyy-MM-dd HH:mm:ss";

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

        var isFilterEmpty = arguments.DistrictId is null &&
                            arguments.DeliveryTimeString is null;

        if (isFilterEmpty)
            throw new ArgumentException("Не заданы аргументы фильтрации. Укажите хотя бы одно значение для фильтрации.");

        if (arguments.DeliveryTimeString is not null)
        {
            if (!DateTime.TryParseExact(arguments.DeliveryTimeString, DateFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                throw new FormatException($"Время доставки должно быть указано в формате '{DateFormat}'.");
            arguments.DeliveryTime = parsedDate;
        }
    }
}

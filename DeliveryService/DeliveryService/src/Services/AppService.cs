using CommandLine;
using DeliveryService.Models.CommandLine;
using DeliveryService.src.Services.Abstractions;
using Serilog;

namespace DeliveryService.Services;
public sealed class AppService
{
    private readonly ILogger _logger;
    private readonly IArgumentsValidator _argumentsValidator;

    public AppService(ILogger logger, IArgumentsValidator argumentsValidator)
    {
        _logger = logger;
        _argumentsValidator = argumentsValidator;
    }

    public void Run(string[] args)
    {
        try
        {
            _logger.Information(string.Join(" ", args));
            var parser = new Parser(config =>
            {
                config.CaseSensitive = false;
                config.CaseInsensitiveEnumValues = true;
            });

            var arguments = parser
                .ParseArguments<Arguments>(args)
                .WithParsed(_argumentsValidator.Validate)
                .WithNotParsed(_argumentsValidator.HandleErrors)
                .Value;


        }
        catch (Exception ex)
        {
            var message = "Приложение завершилось с ошибкой";
            _logger.Fatal(ex, $"{message}:{Environment.NewLine}{ex}");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}

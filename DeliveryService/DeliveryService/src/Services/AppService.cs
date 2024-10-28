using CommandLine;
using DeliveryService.Models.CommandLine;
using DeliveryService.Services.Abstractions;
using Serilog;

namespace DeliveryService.Services;
public sealed class AppService
{
    private readonly ILogger _logger;
    private readonly IArgumentsValidator _argumentsValidator;
    private readonly IArgumentParser _argumentsParser;
    private readonly IOrderFilterProvider _orderHandler;
    private readonly IOrderInformer _orderInformer;

    public AppService(ILogger logger,
        IArgumentsValidator argumentsValidator,
        IArgumentParser argumentsParser,
        IOrderFilterProvider orderHandler,
        IOrderInformer orderInformer)
    {
        _logger = logger;
        _argumentsValidator = argumentsValidator;
        _argumentsParser = argumentsParser;
        _orderHandler = orderHandler;
        _orderInformer = orderInformer;
    }

    public async Task RunAsync(string[] args)
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

            var filter = _argumentsParser.ParseArgumentsToFilter(arguments);

            var orders = await _orderHandler.GetFilteredOrdersAsync(filter);

            _orderInformer.ShowInfo(orders);
        }
        catch (Exception ex)
        {
            _logger.Fatal(ex, $"Приложение завершилось с ошибкой:{Environment.NewLine}{ex.Message}");
        }
        finally
        {
            Log.CloseAndFlush();
        }
    }
}

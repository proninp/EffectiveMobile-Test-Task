using DeliveryService.Services.Abstractions;
using DeliveryService.src.Models;

namespace DeliveryService.src.Services;
public sealed class OrderHandler : IOrderHandler
{
    public Task FilterOrdersAsync(OrderFilter orderFilter)
    {
        throw new NotImplementedException();
    }
}

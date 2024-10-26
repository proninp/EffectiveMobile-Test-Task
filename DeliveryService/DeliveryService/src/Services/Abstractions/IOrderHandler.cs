using DeliveryService.src.Models;

namespace DeliveryService.Services.Abstractions;
public interface IOrderHandler
{
    Task FilterOrdersAsync(OrderFilter orderFilter);
}

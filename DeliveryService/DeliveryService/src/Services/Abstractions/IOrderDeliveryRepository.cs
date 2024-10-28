using DeliveryService.Models;

namespace DeliveryService.src.Services.Abstractions;
public interface IOrderDeliveryRepository
{
    Task<List<Order>> Get(OrderFilter filter);

    Task<List<Delivery>> SaveAsync(IEnumerable<Order> orders);
}

using DeliveryService.Models;

namespace DeliveryService.Services.Abstractions;
public interface IOrderFilterProvider
{
    Task<List<Order>> GetFilteredOrdersAsync(OrderFilter orderFilter);
}

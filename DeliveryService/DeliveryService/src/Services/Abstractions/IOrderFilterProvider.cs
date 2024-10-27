using DeliveryService.Models;
using DeliveryService.Models;

namespace DeliveryService.Services.Abstractions;
public interface IOrderFilterProvider
{
    Task<Order[]> GetFilteredOrdersAsync(OrderFilter orderFilter);
}

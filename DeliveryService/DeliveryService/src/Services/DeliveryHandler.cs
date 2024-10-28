using DeliveryService.Models;
using DeliveryService.Services.Abstractions;
using DeliveryService.src.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace DeliveryService.Services;
public sealed class DeliveryHandler : IOrderFilterProvider
{
    private readonly IOrderDeliveryRepository _orderDeliveryRepository;

    public DeliveryHandler(IOrderDeliveryRepository deliveryRepository)
    {
        _orderDeliveryRepository = deliveryRepository;
    }

    public async Task<List<Order>> GetFilteredOrdersAsync(OrderFilter orderFilter)
    {
        var orders = await _orderDeliveryRepository.Get(orderFilter);

        var earliestOrder = orders.OrderBy(o => o.DeliveryTime).FirstOrDefault();

        if (earliestOrder is null)
        {
            return new List<Order>();
        }

        orders = orders.Where(o => o.DeliveryTime <= earliestOrder.DeliveryTime.AddMinutes(30)).ToList();

        _ = await _orderDeliveryRepository.SaveAsync(orders);

        return orders;
    }
}
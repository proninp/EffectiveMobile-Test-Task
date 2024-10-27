using DeliveryService.Models;
using DeliveryService.Services.Abstractions;
using DeliveryService.Data;
using Microsoft.EntityFrameworkCore;

namespace DeliveryService.Services;
public sealed class DeliveryHandler : IOrderFilterProvider
{
    private readonly AppDbContext _context;

    public DeliveryHandler(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Order[]> GetFilteredOrdersAsync(OrderFilter orderFilter)
    {
        var query = _context.Orders.AsQueryable();

        if (orderFilter.DistrictId.HasValue)
        {
            query = query.Where(o => o.DistrictId == orderFilter.DistrictId.Value);
        }

        if (orderFilter.DeliveryTime.HasValue)
        {
            query = query.Where(o => o.DeliveryTime >= orderFilter.DeliveryTime.Value);
        }
        
        var earliestOrder = await query.OrderBy(o => o.DeliveryTime).FirstOrDefaultAsync();

        if (earliestOrder is null)
        {
            return new Order[0];
        }

        query = query.Where(o => o.DeliveryTime <= earliestOrder.DeliveryTime.AddMinutes(30));
        var orders = await query.AsNoTracking().ToArrayAsync();

        await LogDeliveriesAsync(orders);
        
        return orders;
    }

    private async Task LogDeliveriesAsync(IEnumerable<Order> orders)
    {
        await Task.WhenAll(orders.Select(o => LogDeliveryAsync(o.Id, o.DistrictId)));
        await _context.SaveChangesAsync();
    }

    private async Task LogDeliveryAsync(long orderId, long districtId)
    {
        var delivery = await _context.Deliveries
            .FirstOrDefaultAsync(d => d.OrderId == orderId && d.DistrictId == districtId);

        if (delivery is not null)
        {
            delivery.LastDeliveryFilterTime = DateTime.UtcNow;
        }
        else
        {
            delivery = new Delivery
            {
                OrderId = orderId,
                DistrictId = districtId,
                LastDeliveryFilterTime = DateTime.UtcNow
            };
            _context.Deliveries.Add(delivery);
        }
    }
}
using DeliveryService.Data;
using DeliveryService.Models;
using DeliveryService.src.Services.Abstractions;
using Microsoft.EntityFrameworkCore;

namespace DeliveryService.src.Services;
public class OrderDeliveryRepository : IOrderDeliveryRepository
{
    private readonly AppDbContext _context;

    public OrderDeliveryRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Order>> Get(OrderFilter filter)
    {
        var query = _context.Orders.AsQueryable().AsNoTracking();

        if (filter.DistrictId.HasValue)
        {
            query = query.Where(o => o.DistrictId == filter.DistrictId.Value);
        }

        if (filter.DeliveryTime.HasValue)
        {
            query = query.Where(o => o.DeliveryTime >= filter.DeliveryTime.Value);
        }

        return await query.ToListAsync();
    }

    public async Task<List<Delivery>> SaveAsync(IEnumerable<Order> orders)
    {
        var deliveries = new List<Delivery>(orders.Count());
        foreach (var order in orders)
            deliveries.Add(await SaveDeliveryAsync(order.Id, order.DistrictId));
        await _context.SaveChangesAsync();
        return deliveries;
    }

    private async Task<Delivery> SaveDeliveryAsync(long orderId, long districtId)
    {
        var delivery = await _context.Deliveries
            .FirstOrDefaultAsync(d => d.OrderId == orderId && d.DistrictId == districtId);

        if (delivery is not null)
        {
            delivery.LastDeliveryFilterTime = DateTime.Now;
        }
        else
        {
            delivery = new Delivery
            {
                OrderId = orderId,
                DistrictId = districtId,
                LastDeliveryFilterTime = DateTime.Now
            };
            _context.Deliveries.Add(delivery);
        }
        return delivery;
    }
}

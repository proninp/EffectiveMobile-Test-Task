using DeliveryService.Models;

namespace DeliveryService.Services.Abstractions;
public interface IOrderInformer
{
    void ShowInfo(IEnumerable<Order> orders);
}

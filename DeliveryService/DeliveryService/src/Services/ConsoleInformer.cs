using DeliveryService.Models;
using DeliveryService.Services.Abstractions;
using System.Text;

namespace DeliveryService.src.Services;
public sealed class ConsoleInformer : IOrderInformer
{
    public void ShowInfo(IEnumerable<Order> orders)
    {
        ShowAttentionInfo($"Найдено заказов: {orders.Count()}");
        
        if (orders.Count() > 0)
        {
            var ordersMessage = new StringBuilder()
                .AppendLine()
                .Append(string.Join(Environment.NewLine, orders.Select(order => order.ToString())));
            ShowInfo(ordersMessage.ToString());
        }
    }

    private void ColoredPrint(string info, ConsoleColor color)
    {
        var currentColor = Console.ForegroundColor;
        Console.ForegroundColor = color;
        Console.WriteLine(info);
        Console.ForegroundColor = currentColor;
    }

    public void ShowAttentionInfo(string info)
    {
        ColoredPrint(info, ConsoleColor.Magenta);
    }

    public void ShowInfo(string info)
    {
        Console.WriteLine(info);
    }
}

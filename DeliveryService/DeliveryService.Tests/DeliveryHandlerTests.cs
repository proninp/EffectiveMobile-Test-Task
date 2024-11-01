using DeliveryService.Models;
using DeliveryService.Services;
using DeliveryService.src.Services.Abstractions;
using FluentAssertions;
using Moq;

namespace DeliveryService.Tests;
public class DeliveryHandlerTests
{
    private readonly Mock<IOrderDeliveryRepository> _repositoryMock;
    private readonly DeliveryHandler _deliveryHandler;

    public DeliveryHandlerTests()
    {
        _repositoryMock = new Mock<IOrderDeliveryRepository>();
        _repositoryMock.Setup(repo => repo.SaveAsync(It.IsAny<Order[]>())).ReturnsAsync(new List<Delivery>());
        
        _deliveryHandler = new DeliveryHandler(_repositoryMock.Object);
    }

    [Fact]
    public async Task GetFilteredOrdersAsync_NoOrders_ReturnsEmptyList()
    {
        // Arrange
        var orderFilter = new OrderFilter
        {
            DistrictId = 1,
            DeliveryTime = DateTime.Now
        };

        _repositoryMock.Setup(repo => repo.Get(It.IsAny<OrderFilter>())).ReturnsAsync(new List<Order>());

        // Act
        var result = await _deliveryHandler.GetFilteredOrdersAsync(orderFilter);

        // Assert
        result.Should().BeEmpty();
    }

    [Theory]
    [InlineData(1, "2024-10-28 14:00:00")]
    [InlineData(2, "2024-10-28 14:05:00")]
    public async Task GetFilteredOrdersAsync_WithValidFilter_ReturnsFilteredOrders(long districtId, string deliveryTimeString)
    {
        // Arrange
        var deliveryTime = DateTime.Parse(deliveryTimeString);
        var orderFilter = new OrderFilter
        {
            DistrictId = districtId,
            DeliveryTime = deliveryTime
        };

        var orders = new List<Order>
        {
            new Order { Id = 1, DistrictId = districtId, DeliveryTime = deliveryTime.AddMinutes(5) },
            new Order { Id = 2, DistrictId = districtId, DeliveryTime = deliveryTime.AddMinutes(20) },
            new Order { Id = 3, DistrictId = districtId, DeliveryTime = deliveryTime.AddMinutes(45) },
        };

        _repositoryMock.Setup(repo => repo.Get(It.IsAny<OrderFilter>())).ReturnsAsync(orders);

        // Act
        var result = await _deliveryHandler.GetFilteredOrdersAsync(orderFilter);

        // Assert
        Assert.Equal(2, result.Count);
        Assert.All(result, o => Assert.Equal(districtId, o.DistrictId));
        Assert.All(result, o => Assert.True(o.DeliveryTime >= deliveryTime));
    }

    [Fact]
    public async Task GetFilteredOrdersAsync_OrdersOutsideTimeFrame_ReturnsFilteredOrders()
    {
        // Arrange
        var orderFilter = new OrderFilter
        {
            DistrictId = 1,
            DeliveryTime = DateTime.Now.AddMinutes(-15)
        };

        var orders = new List<Order>
        {
            new Order { Id = 1, DistrictId = 1, DeliveryTime = DateTime.Now.AddMinutes(10) },
            new Order { Id = 2, DistrictId = 1, DeliveryTime = DateTime.Now.AddMinutes(5) }
        };

        _repositoryMock.Setup(repo => repo.Get(It.IsAny<OrderFilter>())).ReturnsAsync(orders);

        // Act
        var result = await _deliveryHandler.GetFilteredOrdersAsync(orderFilter);

        // Assert
        Assert.Equal(2, result.Count);
        Assert.All(result, o => Assert.True(o.DeliveryTime <= orderFilter.DeliveryTime.Value.AddMinutes(30)));
    }
}
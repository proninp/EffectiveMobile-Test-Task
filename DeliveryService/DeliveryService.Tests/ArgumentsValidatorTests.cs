using DeliveryService.Models.CommandLine;
using DeliveryService.Services;
using System.Globalization;

namespace DeliveryService.Tests;

public class ArgumentsValidatorTests
{
    private readonly ArgumentsValidator _validator;

    public ArgumentsValidatorTests()
    {
        _validator = new ArgumentsValidator();
    }

    [Fact]
    public void Validate_ShouldThrowArgumentException_WhenFilterArgumentsAreEmpty()
    {
        // Arrange
        var arguments = new Arguments
        {
            DistrictId = null,
            DeliveryTimeString = null
        };

        // Act
        var exception = Assert.Throws<ArgumentException>(() => _validator.Validate(arguments));

        // Assert
        Assert.Equal("Не заданы аргументы фильтрации. Укажите хотя бы одно значение для фильтрации.", exception.Message);
    }

    [Theory]
    [InlineData("2024-10-28 14:30:00", "2024-10-28 14:30:00")]
    [InlineData("2024-10-28 15:45:00", "2024-10-28 15:45:00")]
    public void Validate_ShouldSetDeliveryTime_WhenDeliveryTimeStringIsValid(string deliveryTimeString, string expectedDateString)
    {
        // Arrange
        var expectedDate = DateTime.ParseExact(expectedDateString, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

        var arguments = new Arguments
        {
            DistrictId = 1,
            DeliveryTimeString = deliveryTimeString
        };

        // Act
        _validator.Validate(arguments);

        // Assert
        Assert.Equal(expectedDate, arguments.DeliveryTime);
    }

    [Theory]
    [InlineData("2024-10-28", "yyyy-MM-dd HH:mm:ss")] // Invalid format
    [InlineData("2024/10/28 14:30", "yyyy-MM-dd HH:mm:ss")] // Invalid format
    public void Validate_ShouldThrowFormatException_WhenDeliveryTimeStringIsInvalid(string deliveryTimeString, string format)
    {
        // Arrange
        var arguments = new Arguments
        {
            DistrictId = 1,
            DeliveryTimeString = deliveryTimeString
        };

        // Act
        var exception = Assert.Throws<FormatException>(() => _validator.Validate(arguments));

        // Assert
        Assert.Equal($"Время доставки должно быть указано в формате '{format}'.", exception.Message);
    }

    [Fact]
    public void Validate_ShouldNotThrow_WhenDistrictIdIsProvidedWithoutDeliveryTimeString()
    {
        // Arrange
        var arguments = new Arguments
        {
            DistrictId = 1
        };

        // Act & Assert
        var exception = Record.Exception(() => _validator.Validate(arguments));
        Assert.Null(exception);
    }

    [Fact]
    public void Validate_ShouldNotThrow_WhenDeliveryTimeStringIsProvidedWithoutDistrictId()
    {
        // Arrange
        var arguments = new Arguments
        {
            DeliveryTimeString = "2024-10-28 14:05:00"
        };

        // Act & Assert
        var exception = Record.Exception(() => _validator.Validate(arguments));
        Assert.Null(exception);
    }
}
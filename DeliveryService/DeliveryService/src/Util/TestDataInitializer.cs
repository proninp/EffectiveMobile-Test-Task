using Microsoft.EntityFrameworkCore.Migrations;

namespace DeliveryService.src.Util;
public class TestDataInitializer
{
    public static void InitializeData(MigrationBuilder migrationBuilder)
    {
        migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "Name" },
                values: GetDistrictsData());

        migrationBuilder.InsertData(
            table: "Orders",
            columns: new[] { "Id", "DistrictId", "Weight", "DeliveryTime" },
            values: GetOrdersData());
    }
    
    private static object[,] GetDistrictsData()
    {
        return new object[,]
        {
            { 1, "Tasmania" },
            { 2, "Colorado" },
            { 3, "Arizona" },
            { 4, "Western Australia" },
            { 5, "Yukon" },
            { 6, "Australian Capital Territory" },
            { 7, "Tasmania" },
            { 8, "Pennsylvania" },
            { 9, "Western Australia" },
            { 10, "Alaska" },
            { 11, "Alberta" },
            { 12, "Northern Territory" },
            { 13, "Yukon" },
            { 14, "Colorado" },
            { 15, "Victoria" }
        };
    }

    private static object[,] GetOrdersData()
    {
        return new object[,]
        {
            { 1, 10, 0.9, new DateTime(2024, 10, 28, 12, 2, 13) },
            { 2, 9, 1.0, new DateTime(2024, 10, 28, 12, 5, 42) },
            { 3, 1, 0.7, new DateTime(2024, 10, 28, 12, 8, 21) },
            { 4, 7, 0.6, new DateTime(2024, 10, 28, 12, 10, 56) },
            { 5, 2, 1.0, new DateTime(2024, 10, 28, 12, 13, 29) },
            { 6, 5, 0.7, new DateTime(2024, 10, 28, 12, 15, 35) },
            { 7, 2, 1.2, new DateTime(2024, 10, 28, 12, 18, 10) },
            { 8, 15, 0.9, new DateTime(2024, 10, 28, 12, 20, 47) },
            { 9, 6, 1.0, new DateTime(2024, 10, 28, 12, 22, 59) },
            { 10, 8, 1.0, new DateTime(2024, 10, 28, 12, 25, 32) },
            { 11, 7, 1.4, new DateTime(2024, 10, 28, 12, 28, 18) },
            { 12, 8, 0.9, new DateTime(2024, 10, 28, 12, 30, 44) },
            { 13, 5, 1.2, new DateTime(2024, 10, 28, 12, 32, 9) },
            { 14, 3, 1.3, new DateTime(2024, 10, 28, 12, 34, 26) },
            { 15, 8, 1.5, new DateTime(2024, 10, 28, 12, 36, 49) },
            { 16, 4, 0.7, new DateTime(2024, 10, 28, 12, 38, 52) },
            { 17, 5, 1.1, new DateTime(2024, 10, 28, 12, 40, 33) },
            { 18, 8, 1.1, new DateTime(2024, 10, 28, 12, 42, 14) },
            { 19, 12, 1.0, new DateTime(2024, 10, 28, 12, 43, 58) },
            { 20, 12, 0.9, new DateTime(2024, 10, 28, 12, 46, 20) },
            { 21, 9, 0.9, new DateTime(2024, 10, 28, 12, 47, 45) },
            { 22, 14, 1.4, new DateTime(2024, 10, 28, 12, 49, 6) },
            { 23, 4, 0.9, new DateTime(2024, 10, 28, 12, 50, 57) },
            { 24, 3, 1.0, new DateTime(2024, 10, 28, 12, 52, 33) },
            { 25, 4, 1.1, new DateTime(2024, 10, 28, 12, 54, 10) },
            { 26, 6, 0.9, new DateTime(2024, 10, 28, 12, 55, 44) },
            { 27, 1, 1.2, new DateTime(2024, 10, 28, 12, 57, 18) },
            { 28, 2, 1.2, new DateTime(2024, 10, 28, 12, 58, 54) },
            { 29, 5, 0.9, new DateTime(2024, 10, 28, 13, 0, 23) },
            { 30, 5, 1.2, new DateTime(2024, 10, 28, 13, 1, 39) },
            { 31, 6, 1.1, new DateTime(2024, 10, 28, 13, 2, 58) },
            { 32, 13, 1.3, new DateTime(2024, 10, 28, 13, 4, 23) },
            { 33, 5, 0.8, new DateTime(2024, 10, 28, 13, 5, 44) },
            { 34, 2, 1.3, new DateTime(2024, 10, 28, 13, 7, 15) },
            { 35, 13, 1.2, new DateTime(2024, 10, 28, 13, 8, 37) },
            { 36, 13, 1.0, new DateTime(2024, 10, 28, 13, 9, 58) },
            { 37, 7, 0.9, new DateTime(2024, 10, 28, 13, 11, 14) },
            { 38, 10, 0.8, new DateTime(2024, 10, 28, 13, 12, 36) },
            { 39, 6, 1.0, new DateTime(2024, 10, 28, 13, 13, 57) },
            { 40, 12, 1.2, new DateTime(2024, 10, 28, 13, 15, 28) },
            { 41, 3, 1.1, new DateTime(2024, 10, 28, 13, 17, 5) },
            { 42, 12, 1.0, new DateTime(2024, 10, 28, 13, 18, 47) },
            { 43, 14, 1.0, new DateTime(2024, 10, 28, 13, 19, 29) },
            { 44, 7, 1.0, new DateTime(2024, 10, 28, 13, 21, 58) },
            { 45, 9, 1.3, new DateTime(2024, 10, 28, 13, 23, 21) },
            { 46, 2, 1.4, new DateTime(2024, 10, 28, 13, 24, 43) },
            { 47, 11, 0.9, new DateTime(2024, 10, 28, 13, 26, 4) },
            { 48, 3, 1.2, new DateTime(2024, 10, 28, 13, 27, 46) },
            { 49, 7, 1.1, new DateTime(2024, 10, 28, 13, 29, 7) },
            { 50, 4, 1.2, new DateTime(2024, 10, 28, 13, 30, 43) },
            { 51, 5, 0.8, new DateTime(2024, 10, 28, 13, 32, 24) },
            { 52, 3, 1.4, new DateTime(2024, 10, 28, 13, 33, 39) },
            { 53, 6, 1.1, new DateTime(2024, 10, 28, 13, 35, 7) },
            { 54, 5, 1.0, new DateTime(2024, 10, 28, 13, 36, 51) },
            { 55, 2, 1.2, new DateTime(2024, 10, 28, 13, 38, 20) },
            { 56, 3, 1.1, new DateTime(2024, 10, 28, 13, 39, 42) },
            { 57, 8, 0.9, new DateTime(2024, 10, 28, 13, 41, 15) },
            { 58, 9, 1.2, new DateTime(2024, 10, 28, 13, 43, 2) },
            { 59, 12, 0.8, new DateTime(2024, 10, 28, 13, 44, 23) },
            { 60, 5, 0.9, new DateTime(2024, 10, 28, 13, 45, 58) },
            { 61, 3, 1.0, new DateTime(2024, 10, 28, 13, 47, 21) },
            { 62, 10, 1.3, new DateTime(2024, 10, 28, 13, 49, 44) },
            { 63, 8, 1.2, new DateTime(2024, 10, 28, 13, 50, 55) },
            { 64, 7, 1.1, new DateTime(2024, 10, 28, 13, 52, 13) },
            { 65, 3, 1.2, new DateTime(2024, 10, 28, 13, 53, 47) },
            { 66, 9, 1.1, new DateTime(2024, 10, 28, 13, 54, 32) },
            { 67, 11, 1.0, new DateTime(2024, 10, 28, 13, 56, 20) },
            { 68, 5, 1.4, new DateTime(2024, 10, 28, 13, 57, 44) },
            { 69, 2, 1.3, new DateTime(2024, 10, 28, 13, 59, 31) },
            { 70, 13, 1.0, new DateTime(2024, 10, 28, 13, 1, 3) },
            { 71, 6, 1.1, new DateTime(2024, 10, 28, 13, 2, 57) },
            { 72, 2, 1.2, new DateTime(2024, 10, 28, 13, 4, 13) },
            { 73, 5, 1.1, new DateTime(2024, 10, 28, 13, 5, 28) },
            { 74, 8, 0.8, new DateTime(2024, 10, 28, 13, 7, 19) },
            { 75, 6, 0.9, new DateTime(2024, 10, 28, 13, 8, 39) },
            { 76, 11, 0.8, new DateTime(2024, 10, 28, 13, 10, 53) },
            { 77, 8, 0.9, new DateTime(2024, 10, 28, 13, 12, 7) },
            { 78, 3, 1.2, new DateTime(2024, 10, 28, 13, 13, 45) },
            { 79, 4, 1.3, new DateTime(2024, 10, 28, 13, 15, 23) },
            { 80, 7, 1.0, new DateTime(2024, 10, 28, 13, 17, 32) },
            { 81, 9, 0.9, new DateTime(2024, 10, 28, 13, 19, 18) },
            { 82, 5, 1.1, new DateTime(2024, 10, 28, 13, 20, 47) },
            { 83, 10, 1.2, new DateTime(2024, 10, 28, 13, 22, 31) },
            { 84, 12, 1.1, new DateTime(2024, 10, 28, 13, 24, 8) },
            { 85, 7, 1.3, new DateTime(2024, 10, 28, 13, 26, 29) },
            { 86, 4, 0.9, new DateTime(2024, 10, 28, 13, 28, 5) },
            { 87, 3, 1.2, new DateTime(2024, 10, 28, 13, 29, 51) },
            { 88, 9, 1.1, new DateTime(2024, 10, 28, 13, 31, 43) },
            { 89, 13, 1.0, new DateTime(2024, 10, 28, 13, 33, 28) },
            { 90, 8, 1.4, new DateTime(2024, 10, 28, 13, 35, 12) },
            { 91, 10, 1.3, new DateTime(2024, 10, 28, 13, 36, 59) },
            { 92, 7, 1.1, new DateTime(2024, 10, 28, 13, 38, 47) },
            { 93, 5, 1.2, new DateTime(2024, 10, 28, 13, 40, 22) },
            { 94, 11, 0.9, new DateTime(2024, 10, 28, 13, 42, 5) },
            { 95, 3, 1.0, new DateTime(2024, 10, 28, 13, 43, 51) },
            { 96, 4, 1.3, new DateTime(2024, 10, 28, 13, 45, 38) },
            { 97, 9, 1.2, new DateTime(2024, 10, 28, 13, 47, 26) },
            { 98, 8, 0.9, new DateTime(2024, 10, 28, 13, 49, 3) },
            { 99, 6, 1.0, new DateTime(2024, 10, 28, 13, 50, 47) },
            { 100, 2, 1.1, new DateTime(2024, 10, 28, 13, 52, 35) }
        };
    }
}

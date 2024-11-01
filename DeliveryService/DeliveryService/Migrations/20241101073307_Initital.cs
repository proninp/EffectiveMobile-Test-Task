using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DeliveryService.Migrations
{
    /// <inheritdoc />
    public partial class Initital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Weight = table.Column<double>(type: "double precision", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    DeliveryTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Deliveries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    OrderId = table.Column<long>(type: "bigint", nullable: false),
                    DistrictId = table.Column<long>(type: "bigint", nullable: false),
                    LastDeliveryFilterTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deliveries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deliveries_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Deliveries_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1L, "Tasmania" },
                    { 2L, "Colorado" },
                    { 3L, "Arizona" },
                    { 4L, "Western Australia" },
                    { 5L, "Yukon" },
                    { 6L, "Australian Capital Territory" },
                    { 7L, "Tasmania" },
                    { 8L, "Pennsylvania" },
                    { 9L, "Western Australia" },
                    { 10L, "Alaska" },
                    { 11L, "Alberta" },
                    { 12L, "Northern Territory" },
                    { 13L, "Yukon" },
                    { 14L, "Colorado" },
                    { 15L, "Victoria" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "DeliveryTime", "DistrictId", "Weight" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 10, 28, 12, 2, 13, 0, DateTimeKind.Unspecified), 10L, 0.90000000000000002 },
                    { 2L, new DateTime(2024, 10, 28, 12, 5, 42, 0, DateTimeKind.Unspecified), 9L, 1.0 },
                    { 3L, new DateTime(2024, 10, 28, 12, 8, 21, 0, DateTimeKind.Unspecified), 1L, 0.69999999999999996 },
                    { 4L, new DateTime(2024, 10, 28, 12, 10, 56, 0, DateTimeKind.Unspecified), 7L, 0.59999999999999998 },
                    { 5L, new DateTime(2024, 10, 28, 12, 13, 29, 0, DateTimeKind.Unspecified), 2L, 1.0 },
                    { 6L, new DateTime(2024, 10, 28, 12, 15, 35, 0, DateTimeKind.Unspecified), 5L, 0.69999999999999996 },
                    { 7L, new DateTime(2024, 10, 28, 12, 18, 10, 0, DateTimeKind.Unspecified), 2L, 1.2 },
                    { 8L, new DateTime(2024, 10, 28, 12, 20, 47, 0, DateTimeKind.Unspecified), 15L, 0.90000000000000002 },
                    { 9L, new DateTime(2024, 10, 28, 12, 22, 59, 0, DateTimeKind.Unspecified), 6L, 1.0 },
                    { 10L, new DateTime(2024, 10, 28, 12, 25, 32, 0, DateTimeKind.Unspecified), 8L, 1.0 },
                    { 11L, new DateTime(2024, 10, 28, 12, 28, 18, 0, DateTimeKind.Unspecified), 7L, 1.3999999999999999 },
                    { 12L, new DateTime(2024, 10, 28, 12, 30, 44, 0, DateTimeKind.Unspecified), 8L, 0.90000000000000002 },
                    { 13L, new DateTime(2024, 10, 28, 12, 32, 9, 0, DateTimeKind.Unspecified), 5L, 1.2 },
                    { 14L, new DateTime(2024, 10, 28, 12, 34, 26, 0, DateTimeKind.Unspecified), 3L, 1.3 },
                    { 15L, new DateTime(2024, 10, 28, 12, 36, 49, 0, DateTimeKind.Unspecified), 8L, 1.5 },
                    { 16L, new DateTime(2024, 10, 28, 12, 38, 52, 0, DateTimeKind.Unspecified), 4L, 0.69999999999999996 },
                    { 17L, new DateTime(2024, 10, 28, 12, 40, 33, 0, DateTimeKind.Unspecified), 5L, 1.1000000000000001 },
                    { 18L, new DateTime(2024, 10, 28, 12, 42, 14, 0, DateTimeKind.Unspecified), 8L, 1.1000000000000001 },
                    { 19L, new DateTime(2024, 10, 28, 12, 43, 58, 0, DateTimeKind.Unspecified), 12L, 1.0 },
                    { 20L, new DateTime(2024, 10, 28, 12, 46, 20, 0, DateTimeKind.Unspecified), 12L, 0.90000000000000002 },
                    { 21L, new DateTime(2024, 10, 28, 12, 47, 45, 0, DateTimeKind.Unspecified), 9L, 0.90000000000000002 },
                    { 22L, new DateTime(2024, 10, 28, 12, 49, 6, 0, DateTimeKind.Unspecified), 14L, 1.3999999999999999 },
                    { 23L, new DateTime(2024, 10, 28, 12, 50, 57, 0, DateTimeKind.Unspecified), 4L, 0.90000000000000002 },
                    { 24L, new DateTime(2024, 10, 28, 12, 52, 33, 0, DateTimeKind.Unspecified), 3L, 1.0 },
                    { 25L, new DateTime(2024, 10, 28, 12, 54, 10, 0, DateTimeKind.Unspecified), 4L, 1.1000000000000001 },
                    { 26L, new DateTime(2024, 10, 28, 12, 55, 44, 0, DateTimeKind.Unspecified), 6L, 0.90000000000000002 },
                    { 27L, new DateTime(2024, 10, 28, 12, 57, 18, 0, DateTimeKind.Unspecified), 1L, 1.2 },
                    { 28L, new DateTime(2024, 10, 28, 12, 58, 54, 0, DateTimeKind.Unspecified), 2L, 1.2 },
                    { 29L, new DateTime(2024, 10, 28, 13, 0, 23, 0, DateTimeKind.Unspecified), 5L, 0.90000000000000002 },
                    { 30L, new DateTime(2024, 10, 28, 13, 1, 39, 0, DateTimeKind.Unspecified), 5L, 1.2 },
                    { 31L, new DateTime(2024, 10, 28, 13, 2, 58, 0, DateTimeKind.Unspecified), 6L, 1.1000000000000001 },
                    { 32L, new DateTime(2024, 10, 28, 13, 4, 23, 0, DateTimeKind.Unspecified), 13L, 1.3 },
                    { 33L, new DateTime(2024, 10, 28, 13, 5, 44, 0, DateTimeKind.Unspecified), 5L, 0.80000000000000004 },
                    { 34L, new DateTime(2024, 10, 28, 13, 7, 15, 0, DateTimeKind.Unspecified), 2L, 1.3 },
                    { 35L, new DateTime(2024, 10, 28, 13, 8, 37, 0, DateTimeKind.Unspecified), 13L, 1.2 },
                    { 36L, new DateTime(2024, 10, 28, 13, 9, 58, 0, DateTimeKind.Unspecified), 13L, 1.0 },
                    { 37L, new DateTime(2024, 10, 28, 13, 11, 14, 0, DateTimeKind.Unspecified), 7L, 0.90000000000000002 },
                    { 38L, new DateTime(2024, 10, 28, 13, 12, 36, 0, DateTimeKind.Unspecified), 10L, 0.80000000000000004 },
                    { 39L, new DateTime(2024, 10, 28, 13, 13, 57, 0, DateTimeKind.Unspecified), 6L, 1.0 },
                    { 40L, new DateTime(2024, 10, 28, 13, 15, 28, 0, DateTimeKind.Unspecified), 12L, 1.2 },
                    { 41L, new DateTime(2024, 10, 28, 13, 17, 5, 0, DateTimeKind.Unspecified), 3L, 1.1000000000000001 },
                    { 42L, new DateTime(2024, 10, 28, 13, 18, 47, 0, DateTimeKind.Unspecified), 12L, 1.0 },
                    { 43L, new DateTime(2024, 10, 28, 13, 19, 29, 0, DateTimeKind.Unspecified), 14L, 1.0 },
                    { 44L, new DateTime(2024, 10, 28, 13, 21, 58, 0, DateTimeKind.Unspecified), 7L, 1.0 },
                    { 45L, new DateTime(2024, 10, 28, 13, 23, 21, 0, DateTimeKind.Unspecified), 9L, 1.3 },
                    { 46L, new DateTime(2024, 10, 28, 13, 24, 43, 0, DateTimeKind.Unspecified), 2L, 1.3999999999999999 },
                    { 47L, new DateTime(2024, 10, 28, 13, 26, 4, 0, DateTimeKind.Unspecified), 11L, 0.90000000000000002 },
                    { 48L, new DateTime(2024, 10, 28, 13, 27, 46, 0, DateTimeKind.Unspecified), 3L, 1.2 },
                    { 49L, new DateTime(2024, 10, 28, 13, 29, 7, 0, DateTimeKind.Unspecified), 7L, 1.1000000000000001 },
                    { 50L, new DateTime(2024, 10, 28, 13, 30, 43, 0, DateTimeKind.Unspecified), 4L, 1.2 },
                    { 51L, new DateTime(2024, 10, 28, 13, 32, 24, 0, DateTimeKind.Unspecified), 5L, 0.80000000000000004 },
                    { 52L, new DateTime(2024, 10, 28, 13, 33, 39, 0, DateTimeKind.Unspecified), 3L, 1.3999999999999999 },
                    { 53L, new DateTime(2024, 10, 28, 13, 35, 7, 0, DateTimeKind.Unspecified), 6L, 1.1000000000000001 },
                    { 54L, new DateTime(2024, 10, 28, 13, 36, 51, 0, DateTimeKind.Unspecified), 5L, 1.0 },
                    { 55L, new DateTime(2024, 10, 28, 13, 38, 20, 0, DateTimeKind.Unspecified), 2L, 1.2 },
                    { 56L, new DateTime(2024, 10, 28, 13, 39, 42, 0, DateTimeKind.Unspecified), 3L, 1.1000000000000001 },
                    { 57L, new DateTime(2024, 10, 28, 13, 41, 15, 0, DateTimeKind.Unspecified), 8L, 0.90000000000000002 },
                    { 58L, new DateTime(2024, 10, 28, 13, 43, 2, 0, DateTimeKind.Unspecified), 9L, 1.2 },
                    { 59L, new DateTime(2024, 10, 28, 13, 44, 23, 0, DateTimeKind.Unspecified), 12L, 0.80000000000000004 },
                    { 60L, new DateTime(2024, 10, 28, 13, 45, 58, 0, DateTimeKind.Unspecified), 5L, 0.90000000000000002 },
                    { 61L, new DateTime(2024, 10, 28, 13, 47, 21, 0, DateTimeKind.Unspecified), 3L, 1.0 },
                    { 62L, new DateTime(2024, 10, 28, 13, 49, 44, 0, DateTimeKind.Unspecified), 10L, 1.3 },
                    { 63L, new DateTime(2024, 10, 28, 13, 50, 55, 0, DateTimeKind.Unspecified), 8L, 1.2 },
                    { 64L, new DateTime(2024, 10, 28, 13, 52, 13, 0, DateTimeKind.Unspecified), 7L, 1.1000000000000001 },
                    { 65L, new DateTime(2024, 10, 28, 13, 53, 47, 0, DateTimeKind.Unspecified), 3L, 1.2 },
                    { 66L, new DateTime(2024, 10, 28, 13, 54, 32, 0, DateTimeKind.Unspecified), 9L, 1.1000000000000001 },
                    { 67L, new DateTime(2024, 10, 28, 13, 56, 20, 0, DateTimeKind.Unspecified), 11L, 1.0 },
                    { 68L, new DateTime(2024, 10, 28, 13, 57, 44, 0, DateTimeKind.Unspecified), 5L, 1.3999999999999999 },
                    { 69L, new DateTime(2024, 10, 28, 13, 59, 31, 0, DateTimeKind.Unspecified), 2L, 1.3 },
                    { 70L, new DateTime(2024, 10, 28, 13, 1, 3, 0, DateTimeKind.Unspecified), 13L, 1.0 },
                    { 71L, new DateTime(2024, 10, 28, 13, 2, 57, 0, DateTimeKind.Unspecified), 6L, 1.1000000000000001 },
                    { 72L, new DateTime(2024, 10, 28, 13, 4, 13, 0, DateTimeKind.Unspecified), 2L, 1.2 },
                    { 73L, new DateTime(2024, 10, 28, 13, 5, 28, 0, DateTimeKind.Unspecified), 5L, 1.1000000000000001 },
                    { 74L, new DateTime(2024, 10, 28, 13, 7, 19, 0, DateTimeKind.Unspecified), 8L, 0.80000000000000004 },
                    { 75L, new DateTime(2024, 10, 28, 13, 8, 39, 0, DateTimeKind.Unspecified), 6L, 0.90000000000000002 },
                    { 76L, new DateTime(2024, 10, 28, 13, 10, 53, 0, DateTimeKind.Unspecified), 11L, 0.80000000000000004 },
                    { 77L, new DateTime(2024, 10, 28, 13, 12, 7, 0, DateTimeKind.Unspecified), 8L, 0.90000000000000002 },
                    { 78L, new DateTime(2024, 10, 28, 13, 13, 45, 0, DateTimeKind.Unspecified), 3L, 1.2 },
                    { 79L, new DateTime(2024, 10, 28, 13, 15, 23, 0, DateTimeKind.Unspecified), 4L, 1.3 },
                    { 80L, new DateTime(2024, 10, 28, 13, 17, 32, 0, DateTimeKind.Unspecified), 7L, 1.0 },
                    { 81L, new DateTime(2024, 10, 28, 13, 19, 18, 0, DateTimeKind.Unspecified), 9L, 0.90000000000000002 },
                    { 82L, new DateTime(2024, 10, 28, 13, 20, 47, 0, DateTimeKind.Unspecified), 5L, 1.1000000000000001 },
                    { 83L, new DateTime(2024, 10, 28, 13, 22, 31, 0, DateTimeKind.Unspecified), 10L, 1.2 },
                    { 84L, new DateTime(2024, 10, 28, 13, 24, 8, 0, DateTimeKind.Unspecified), 12L, 1.1000000000000001 },
                    { 85L, new DateTime(2024, 10, 28, 13, 26, 29, 0, DateTimeKind.Unspecified), 7L, 1.3 },
                    { 86L, new DateTime(2024, 10, 28, 13, 28, 5, 0, DateTimeKind.Unspecified), 4L, 0.90000000000000002 },
                    { 87L, new DateTime(2024, 10, 28, 13, 29, 51, 0, DateTimeKind.Unspecified), 3L, 1.2 },
                    { 88L, new DateTime(2024, 10, 28, 13, 31, 43, 0, DateTimeKind.Unspecified), 9L, 1.1000000000000001 },
                    { 89L, new DateTime(2024, 10, 28, 13, 33, 28, 0, DateTimeKind.Unspecified), 13L, 1.0 },
                    { 90L, new DateTime(2024, 10, 28, 13, 35, 12, 0, DateTimeKind.Unspecified), 8L, 1.3999999999999999 },
                    { 91L, new DateTime(2024, 10, 28, 13, 36, 59, 0, DateTimeKind.Unspecified), 10L, 1.3 },
                    { 92L, new DateTime(2024, 10, 28, 13, 38, 47, 0, DateTimeKind.Unspecified), 7L, 1.1000000000000001 },
                    { 93L, new DateTime(2024, 10, 28, 13, 40, 22, 0, DateTimeKind.Unspecified), 5L, 1.2 },
                    { 94L, new DateTime(2024, 10, 28, 13, 42, 5, 0, DateTimeKind.Unspecified), 11L, 0.90000000000000002 },
                    { 95L, new DateTime(2024, 10, 28, 13, 43, 51, 0, DateTimeKind.Unspecified), 3L, 1.0 },
                    { 96L, new DateTime(2024, 10, 28, 13, 45, 38, 0, DateTimeKind.Unspecified), 4L, 1.3 },
                    { 97L, new DateTime(2024, 10, 28, 13, 47, 26, 0, DateTimeKind.Unspecified), 9L, 1.2 },
                    { 98L, new DateTime(2024, 10, 28, 13, 49, 3, 0, DateTimeKind.Unspecified), 8L, 0.90000000000000002 },
                    { 99L, new DateTime(2024, 10, 28, 13, 50, 47, 0, DateTimeKind.Unspecified), 6L, 1.0 },
                    { 100L, new DateTime(2024, 10, 28, 13, 52, 35, 0, DateTimeKind.Unspecified), 2L, 1.1000000000000001 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_DistrictId",
                table: "Deliveries",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Deliveries_OrderId",
                table: "Deliveries",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DistrictId",
                table: "Orders",
                column: "DistrictId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deliveries");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Districts");
        }
    }
}

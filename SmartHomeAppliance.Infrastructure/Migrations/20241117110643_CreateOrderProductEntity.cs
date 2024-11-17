using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreateOrderProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Products_ProductId1",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropIndex(
                name: "IX_Orders_ProductId1",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2eac7bad-a111-4916-8b5a-ce343bc9adb9"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("482f8f29-41e9-482b-be79-b65daf7bbb20"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6aec2086-8c18-4431-b8ef-82f6ec32b9ed"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6d96b420-8c4b-4caf-a089-e4a2f0dafb35"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("72d853b6-e77e-47f1-a80a-02e726726785"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c3fec1dd-bc0d-4ea7-9a13-7d4000e81d5b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("c9ad22ba-0871-4dde-9df7-11e39074f2ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2d1e9c0-2af1-49fe-9df3-340caafb6ae4"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("de6493db-6667-4637-9c54-0859b704ce28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f498a1f8-3d76-4094-8acc-0f0145b2ce17"));

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProductId1",
                table: "Orders");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                columns: new[] { "Id", "UserId" });

            migrationBuilder.CreateTable(
                name: "OrderProducts",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderUserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderProducts", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderProducts_Orders_OrderId_OrderUserId",
                        columns: x => new { x.OrderId, x.OrderUserId },
                        principalTable: "Orders",
                        principalColumns: new[] { "Id", "UserId" },
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_OrderProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27424fea-50e9-4e2c-829e-cd6b6c3fae0a", "AQAAAAIAAYagAAAAEDZx7OA7Ce2iutblIzxyd/M3lYSYLxkekZax0sHZHAm5NMwo1P0d0EjVQstXpMBkCw==", "ace4f6de-7d99-46e1-92cc-577cf598328d" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatorId", "DateCreated", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("1098c6d7-3496-4805-b403-2ab8d4da6bcd"), 5, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 6, 42, 134, DateTimeKind.Utc).AddTicks(6906), "Smart plug that monitors energy usage of connected devices in real-time.", "https://via.placeholder.com/400x300.png?text=Energy+Monitor+Plug", "Energy Monitor Plug", 24.99m, 200 },
                    { new Guid("11184402-6abc-4668-b2d1-6a5d8cbf9f66"), 9, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 6, 42, 134, DateTimeKind.Utc).AddTicks(6919), "Weather-based sprinkler system for efficient garden watering.", "https://via.placeholder.com/400x300.png?text=Smart+Sprinkler+System", "Smart Sprinkler System", 199.99m, 20 },
                    { new Guid("152ff38e-2368-4ce4-9118-71fd732341ba"), 8, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 6, 42, 134, DateTimeKind.Utc).AddTicks(6914), "Central hub to control and integrate all smart home devices.", "https://via.placeholder.com/400x300.png?text=Smart+Home+Hub", "Smart Home Hub", 129.99m, 40 },
                    { new Guid("156c6ea6-44ad-4ba5-b4f9-dce7497e79cd"), 2, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 6, 42, 134, DateTimeKind.Utc).AddTicks(6737), "A programmable thermostat that learns your heating and cooling preferences.", "https://via.placeholder.com/400x300.png?text=WiFi+Thermostat", "WiFi Thermostat", 249.99m, 30 },
                    { new Guid("1900304e-ec0d-4307-aec3-290c487df08d"), 3, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 6, 42, 134, DateTimeKind.Utc).AddTicks(6739), "Refrigerator with touch screen, interior cameras, and WiFi connectivity.", "https://via.placeholder.com/400x300.png?text=Smart+Refrigerator", "Smart Refrigerator", 1599.99m, 10 },
                    { new Guid("4b93d674-28fc-4cd5-a5c7-a92761b3a70e"), 6, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 6, 42, 134, DateTimeKind.Utc).AddTicks(6908), "WiFi-enabled robot vacuum with auto-charge and scheduling capabilities.", "https://via.placeholder.com/400x300.png?text=Robot+Vacuum+Cleaner", "Robot Vacuum Cleaner", 299.99m, 75 },
                    { new Guid("698d2bcd-4c4d-4a4b-9b06-bfc8726d4b2f"), 7, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 6, 42, 134, DateTimeKind.Utc).AddTicks(6910), "Waterproof fitness tracker with heart rate monitor and sleep tracking.", "https://via.placeholder.com/400x300.png?text=Smart+Fitness+Tracker", "Smart Fitness Tracker", 59.99m, 120 },
                    { new Guid("7872ac3e-ff1c-4b7f-adea-71e06d5ca505"), 1, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 6, 42, 134, DateTimeKind.Utc).AddTicks(6735), "Color-changing LED light bulbs controllable via app or voice commands.", "https://via.placeholder.com/400x300.png?text=Smart+LED+Light+Bulbs", "Smart LED Light Bulbs (4-Pack)", 39.99m, 150 },
                    { new Guid("80be8554-b3a6-4d9e-a093-d542ca32eb6a"), 0, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 6, 42, 134, DateTimeKind.Utc).AddTicks(6711), "A high-definition doorbell camera with night vision and motion detection.", "https://via.placeholder.com/400x300.png?text=Smart+Doorbell+Camera", "Smart Doorbell Camera", 129.99m, 50 },
                    { new Guid("ddba9729-9388-4e47-b138-6213bf6269ac"), 4, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 6, 42, 134, DateTimeKind.Utc).AddTicks(6774), "Voice-activated smart speaker with high-fidelity sound and assistant integration.", "https://via.placeholder.com/400x300.png?text=Smart+Speaker", "Smart Speaker", 99.99m, 100 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderProducts_OrderId_OrderUserId",
                table: "OrderProducts",
                columns: new[] { "OrderId", "OrderUserId" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1098c6d7-3496-4805-b403-2ab8d4da6bcd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("11184402-6abc-4668-b2d1-6a5d8cbf9f66"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("152ff38e-2368-4ce4-9118-71fd732341ba"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("156c6ea6-44ad-4ba5-b4f9-dce7497e79cd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1900304e-ec0d-4307-aec3-290c487df08d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4b93d674-28fc-4cd5-a5c7-a92761b3a70e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("698d2bcd-4c4d-4a4b-9b06-bfc8726d4b2f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7872ac3e-ff1c-4b7f-adea-71e06d5ca505"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("80be8554-b3a6-4d9e-a093-d542ca32eb6a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ddba9729-9388-4e47-b138-6213bf6269ac"));

            migrationBuilder.AddColumn<string>(
                name: "ProductId",
                table: "Orders",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "ProductId1",
                table: "Orders",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                columns: new[] { "ProductId", "UserId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eeacdc9-28a2-4cf6-8279-a3e18a908548", "AQAAAAIAAYagAAAAEBfoFdQWzwwPgWrm0RpW6I+z/TrtDZQUtD0u5Ffk6LxGhwcgPHrmrTnvseR1XXIdIg==", "f6981f6b-9496-459c-ab9b-d43d9e31bef1" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatorId", "DateCreated", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("2eac7bad-a111-4916-8b5a-ce343bc9adb9"), 9, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 0, 7, 15, 992, DateTimeKind.Utc).AddTicks(4280), "Weather-based sprinkler system for efficient garden watering.", "https://via.placeholder.com/400x300.png?text=Smart+Sprinkler+System", "Smart Sprinkler System", 199.99m, 20 },
                    { new Guid("482f8f29-41e9-482b-be79-b65daf7bbb20"), 2, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 0, 7, 15, 992, DateTimeKind.Utc).AddTicks(4237), "A programmable thermostat that learns your heating and cooling preferences.", "https://via.placeholder.com/400x300.png?text=WiFi+Thermostat", "WiFi Thermostat", 249.99m, 30 },
                    { new Guid("6aec2086-8c18-4431-b8ef-82f6ec32b9ed"), 0, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 0, 7, 15, 992, DateTimeKind.Utc).AddTicks(4205), "A high-definition doorbell camera with night vision and motion detection.", "https://via.placeholder.com/400x300.png?text=Smart+Doorbell+Camera", "Smart Doorbell Camera", 129.99m, 50 },
                    { new Guid("6d96b420-8c4b-4caf-a089-e4a2f0dafb35"), 8, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 0, 7, 15, 992, DateTimeKind.Utc).AddTicks(4277), "Central hub to control and integrate all smart home devices.", "https://via.placeholder.com/400x300.png?text=Smart+Home+Hub", "Smart Home Hub", 129.99m, 40 },
                    { new Guid("72d853b6-e77e-47f1-a80a-02e726726785"), 4, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 0, 7, 15, 992, DateTimeKind.Utc).AddTicks(4266), "Voice-activated smart speaker with high-fidelity sound and assistant integration.", "https://via.placeholder.com/400x300.png?text=Smart+Speaker", "Smart Speaker", 99.99m, 100 },
                    { new Guid("c3fec1dd-bc0d-4ea7-9a13-7d4000e81d5b"), 7, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 0, 7, 15, 992, DateTimeKind.Utc).AddTicks(4273), "Waterproof fitness tracker with heart rate monitor and sleep tracking.", "https://via.placeholder.com/400x300.png?text=Smart+Fitness+Tracker", "Smart Fitness Tracker", 59.99m, 120 },
                    { new Guid("c9ad22ba-0871-4dde-9df7-11e39074f2ba"), 6, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 0, 7, 15, 992, DateTimeKind.Utc).AddTicks(4271), "WiFi-enabled robot vacuum with auto-charge and scheduling capabilities.", "https://via.placeholder.com/400x300.png?text=Robot+Vacuum+Cleaner", "Robot Vacuum Cleaner", 299.99m, 75 },
                    { new Guid("d2d1e9c0-2af1-49fe-9df3-340caafb6ae4"), 1, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 0, 7, 15, 992, DateTimeKind.Utc).AddTicks(4223), "Color-changing LED light bulbs controllable via app or voice commands.", "https://via.placeholder.com/400x300.png?text=Smart+LED+Light+Bulbs", "Smart LED Light Bulbs (4-Pack)", 39.99m, 150 },
                    { new Guid("de6493db-6667-4637-9c54-0859b704ce28"), 3, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 0, 7, 15, 992, DateTimeKind.Utc).AddTicks(4240), "Refrigerator with touch screen, interior cameras, and WiFi connectivity.", "https://via.placeholder.com/400x300.png?text=Smart+Refrigerator", "Smart Refrigerator", 1599.99m, 10 },
                    { new Guid("f498a1f8-3d76-4094-8acc-0f0145b2ce17"), 5, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 0, 7, 15, 992, DateTimeKind.Utc).AddTicks(4269), "Smart plug that monitors energy usage of connected devices in real-time.", "https://via.placeholder.com/400x300.png?text=Energy+Monitor+Plug", "Energy Monitor Plug", 24.99m, 200 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ProductId1",
                table: "Orders",
                column: "ProductId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Products_ProductId1",
                table: "Orders",
                column: "ProductId1",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}

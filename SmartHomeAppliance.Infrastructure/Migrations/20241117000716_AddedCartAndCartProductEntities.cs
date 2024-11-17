using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedCartAndCartProductEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1a990eb5-9612-47f9-b786-832d26f8d008"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("2f500032-141d-4a85-b87f-7b2c79e35943"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("308db4ad-f667-4d31-b0dc-23e3c9610858"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3c5c10e0-6a0c-4130-8f47-7c459debfd5d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("52837550-fcb1-4956-8010-e0f3688f6e3f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("66089760-58fb-4097-bf09-a7d92123e95a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7b35d2d4-a469-4bb2-93c1-b61a0ad32815"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a1f6b49f-0ecd-4ee3-8c6e-8e1f6e7117b6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b8d86bd3-b8f6-4043-9208-5f496613194f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("bf9cebed-a13a-4ca3-88c8-eefc74da1385"));

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CartProducts",
                columns: table => new
                {
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartProducts", x => new { x.CartId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_CartProducts_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_CartProducts_ProductId",
                table: "CartProducts",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CartProducts");

            migrationBuilder.DropTable(
                name: "Carts");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "398abced-06e1-40ec-bbc1-dc1a7292cc12", "AQAAAAIAAYagAAAAENtMi4T1jtg01ippSGCbTjzDOi3o4Sb5OKceWjU/9DYE5o/2UYSG5KOVqkEpXM18aQ==", "816c4524-12b6-46e5-8a4d-46581daf4836" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatorId", "DateCreated", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("1a990eb5-9612-47f9-b786-832d26f8d008"), 1, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 14, 0, 37, 31, 198, DateTimeKind.Utc).AddTicks(7297), "Color-changing LED light bulbs controllable via app or voice commands.", "https://via.placeholder.com/400x300.png?text=Smart+LED+Light+Bulbs", "Smart LED Light Bulbs (4-Pack)", 39.99m, 150 },
                    { new Guid("2f500032-141d-4a85-b87f-7b2c79e35943"), 9, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 14, 0, 37, 31, 198, DateTimeKind.Utc).AddTicks(7377), "Weather-based sprinkler system for efficient garden watering.", "https://via.placeholder.com/400x300.png?text=Smart+Sprinkler+System", "Smart Sprinkler System", 199.99m, 20 },
                    { new Guid("308db4ad-f667-4d31-b0dc-23e3c9610858"), 7, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 14, 0, 37, 31, 198, DateTimeKind.Utc).AddTicks(7350), "Waterproof fitness tracker with heart rate monitor and sleep tracking.", "https://via.placeholder.com/400x300.png?text=Smart+Fitness+Tracker", "Smart Fitness Tracker", 59.99m, 120 },
                    { new Guid("3c5c10e0-6a0c-4130-8f47-7c459debfd5d"), 0, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 14, 0, 37, 31, 198, DateTimeKind.Utc).AddTicks(7275), "A high-definition doorbell camera with night vision and motion detection.", "https://via.placeholder.com/400x300.png?text=Smart+Doorbell+Camera", "Smart Doorbell Camera", 129.99m, 50 },
                    { new Guid("52837550-fcb1-4956-8010-e0f3688f6e3f"), 3, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 14, 0, 37, 31, 198, DateTimeKind.Utc).AddTicks(7306), "Refrigerator with touch screen, interior cameras, and WiFi connectivity.", "https://via.placeholder.com/400x300.png?text=Smart+Refrigerator", "Smart Refrigerator", 1599.99m, 10 },
                    { new Guid("66089760-58fb-4097-bf09-a7d92123e95a"), 4, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 14, 0, 37, 31, 198, DateTimeKind.Utc).AddTicks(7337), "Voice-activated smart speaker with high-fidelity sound and assistant integration.", "https://via.placeholder.com/400x300.png?text=Smart+Speaker", "Smart Speaker", 99.99m, 100 },
                    { new Guid("7b35d2d4-a469-4bb2-93c1-b61a0ad32815"), 8, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 14, 0, 37, 31, 198, DateTimeKind.Utc).AddTicks(7355), "Central hub to control and integrate all smart home devices.", "https://via.placeholder.com/400x300.png?text=Smart+Home+Hub", "Smart Home Hub", 129.99m, 40 },
                    { new Guid("a1f6b49f-0ecd-4ee3-8c6e-8e1f6e7117b6"), 5, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 14, 0, 37, 31, 198, DateTimeKind.Utc).AddTicks(7340), "Smart plug that monitors energy usage of connected devices in real-time.", "https://via.placeholder.com/400x300.png?text=Energy+Monitor+Plug", "Energy Monitor Plug", 24.99m, 200 },
                    { new Guid("b8d86bd3-b8f6-4043-9208-5f496613194f"), 6, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 14, 0, 37, 31, 198, DateTimeKind.Utc).AddTicks(7343), "WiFi-enabled robot vacuum with auto-charge and scheduling capabilities.", "https://via.placeholder.com/400x300.png?text=Robot+Vacuum+Cleaner", "Robot Vacuum Cleaner", 299.99m, 75 },
                    { new Guid("bf9cebed-a13a-4ca3-88c8-eefc74da1385"), 2, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 14, 0, 37, 31, 198, DateTimeKind.Utc).AddTicks(7303), "A programmable thermostat that learns your heating and cooling preferences.", "https://via.placeholder.com/400x300.png?text=WiFi+Thermostat", "WiFi Thermostat", 249.99m, 30 }
                });
        }
    }
}

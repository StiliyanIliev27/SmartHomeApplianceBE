using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedIdentifiersToOrderProductAndCartProductEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartProducts",
                table: "CartProducts");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("1321ad01-7f84-4122-ad8c-e5a6e596b49a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26838143-a5ad-4686-bfa7-7f036859aac1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3e4583f0-382a-43f7-8559-0da8079cee1b"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("417c1d21-ac1e-464f-8f6b-2e1c0415bb50"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("512d579c-89c4-4f0d-90b6-7eb409667c28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("750a14ff-3c28-49a7-85cf-996130156c37"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b78316bb-0c2a-487c-b050-8bdd80892911"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d7dee229-5f26-4c4d-bbf8-c94c37309c87"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e860c84f-d6b7-4a66-b15b-6eaaca830326"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f41dd764-b841-4bfb-ad34-6f8a01f145b2"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "OrderProducts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "CartProducts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts",
                columns: new[] { "ProductId", "OrderId", "Id" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartProducts",
                table: "CartProducts",
                columns: new[] { "CartId", "ProductId", "Id" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5950286c-b07c-4296-997f-004a95144e6a", "AQAAAAIAAYagAAAAEMcxc35XxvE4iTTd6nBbJGfUHYde6wxebzHGvVppygrbUZP9pwGnhy6rInpQhy82gA==", "040b6d1e-76d9-4ccd-9ac9-107e2eb91007" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatorId", "DateCreated", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("02341dc4-f84b-427a-b035-2d3d2b5ad020"), 8, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8407), "Central hub to control and integrate all smart home devices.", "https://via.placeholder.com/400x300.png?text=Smart+Home+Hub", "Smart Home Hub", 129.99m, 40 },
                    { new Guid("13f90cdf-544f-4129-92fa-6a1d6607b32f"), 4, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8389), "Voice-activated smart speaker with high-fidelity sound and assistant integration.", "https://via.placeholder.com/400x300.png?text=Smart+Speaker", "Smart Speaker", 99.99m, 100 },
                    { new Guid("420ddd81-5c18-433b-8a3b-d5ad314da152"), 6, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8401), "WiFi-enabled robot vacuum with auto-charge and scheduling capabilities.", "https://via.placeholder.com/400x300.png?text=Robot+Vacuum+Cleaner", "Robot Vacuum Cleaner", 299.99m, 75 },
                    { new Guid("4421832e-cda1-44bc-9cdc-367bda67cc94"), 1, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8267), "Color-changing LED light bulbs controllable via app or voice commands.", "https://via.placeholder.com/400x300.png?text=Smart+LED+Light+Bulbs", "Smart LED Light Bulbs (4-Pack)", 39.99m, 150 },
                    { new Guid("7c90d8b4-9fec-470e-8db1-624db5083b4f"), 0, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8251), "A high-definition doorbell camera with night vision and motion detection.", "https://via.placeholder.com/400x300.png?text=Smart+Doorbell+Camera", "Smart Doorbell Camera", 129.99m, 50 },
                    { new Guid("9a09d7a9-822b-4fd2-9d8d-f0547de08963"), 2, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8270), "A programmable thermostat that learns your heating and cooling preferences.", "https://via.placeholder.com/400x300.png?text=WiFi+Thermostat", "WiFi Thermostat", 249.99m, 30 },
                    { new Guid("a0025815-e9ae-4dc5-961c-0133f8e3e930"), 5, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8399), "Smart plug that monitors energy usage of connected devices in real-time.", "https://via.placeholder.com/400x300.png?text=Energy+Monitor+Plug", "Energy Monitor Plug", 24.99m, 200 },
                    { new Guid("b36b2ab5-9250-412e-a1da-a72402f6a54d"), 3, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8273), "Refrigerator with touch screen, interior cameras, and WiFi connectivity.", "https://via.placeholder.com/400x300.png?text=Smart+Refrigerator", "Smart Refrigerator", 1599.99m, 10 },
                    { new Guid("d2a908fe-dbe1-44d8-bcac-83cd94129f3d"), 9, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8409), "Weather-based sprinkler system for efficient garden watering.", "https://via.placeholder.com/400x300.png?text=Smart+Sprinkler+System", "Smart Sprinkler System", 199.99m, 20 },
                    { new Guid("deac797f-d5c8-4f4d-9234-3244f7e57b07"), 7, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 14, 15, 53, 710, DateTimeKind.Utc).AddTicks(8404), "Waterproof fitness tracker with heart rate monitor and sleep tracking.", "https://via.placeholder.com/400x300.png?text=Smart+Fitness+Tracker", "Smart Fitness Tracker", 59.99m, 120 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartProducts",
                table: "CartProducts");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("02341dc4-f84b-427a-b035-2d3d2b5ad020"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("13f90cdf-544f-4129-92fa-6a1d6607b32f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("420ddd81-5c18-433b-8a3b-d5ad314da152"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4421832e-cda1-44bc-9cdc-367bda67cc94"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("7c90d8b4-9fec-470e-8db1-624db5083b4f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9a09d7a9-822b-4fd2-9d8d-f0547de08963"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a0025815-e9ae-4dc5-961c-0133f8e3e930"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b36b2ab5-9250-412e-a1da-a72402f6a54d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2a908fe-dbe1-44d8-bcac-83cd94129f3d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("deac797f-d5c8-4f4d-9234-3244f7e57b07"));

            migrationBuilder.DropColumn(
                name: "Id",
                table: "OrderProducts");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "CartProducts");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderProducts",
                table: "OrderProducts",
                columns: new[] { "ProductId", "OrderId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartProducts",
                table: "CartProducts",
                columns: new[] { "CartId", "ProductId" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee8058bd-f172-4283-a791-27fd45bc14ea", "AQAAAAIAAYagAAAAEBh0N7jLeaNwEXYSyGba4q24J/1bmkf31X/pNksTRbvh3hKxzZqDJvh6orcF51jV+w==", "228df020-a6c2-4c82-94c2-02116df05210" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatorId", "DateCreated", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("1321ad01-7f84-4122-ad8c-e5a6e596b49a"), 5, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 12, 2, 2, 50, DateTimeKind.Utc).AddTicks(3291), "Smart plug that monitors energy usage of connected devices in real-time.", "https://via.placeholder.com/400x300.png?text=Energy+Monitor+Plug", "Energy Monitor Plug", 24.99m, 200 },
                    { new Guid("26838143-a5ad-4686-bfa7-7f036859aac1"), 6, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 12, 2, 2, 50, DateTimeKind.Utc).AddTicks(3296), "WiFi-enabled robot vacuum with auto-charge and scheduling capabilities.", "https://via.placeholder.com/400x300.png?text=Robot+Vacuum+Cleaner", "Robot Vacuum Cleaner", 299.99m, 75 },
                    { new Guid("3e4583f0-382a-43f7-8559-0da8079cee1b"), 2, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 12, 2, 2, 50, DateTimeKind.Utc).AddTicks(3246), "A programmable thermostat that learns your heating and cooling preferences.", "https://via.placeholder.com/400x300.png?text=WiFi+Thermostat", "WiFi Thermostat", 249.99m, 30 },
                    { new Guid("417c1d21-ac1e-464f-8f6b-2e1c0415bb50"), 0, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 12, 2, 2, 50, DateTimeKind.Utc).AddTicks(3221), "A high-definition doorbell camera with night vision and motion detection.", "https://via.placeholder.com/400x300.png?text=Smart+Doorbell+Camera", "Smart Doorbell Camera", 129.99m, 50 },
                    { new Guid("512d579c-89c4-4f0d-90b6-7eb409667c28"), 1, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 12, 2, 2, 50, DateTimeKind.Utc).AddTicks(3243), "Color-changing LED light bulbs controllable via app or voice commands.", "https://via.placeholder.com/400x300.png?text=Smart+LED+Light+Bulbs", "Smart LED Light Bulbs (4-Pack)", 39.99m, 150 },
                    { new Guid("750a14ff-3c28-49a7-85cf-996130156c37"), 4, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 12, 2, 2, 50, DateTimeKind.Utc).AddTicks(3289), "Voice-activated smart speaker with high-fidelity sound and assistant integration.", "https://via.placeholder.com/400x300.png?text=Smart+Speaker", "Smart Speaker", 99.99m, 100 },
                    { new Guid("b78316bb-0c2a-487c-b050-8bdd80892911"), 3, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 12, 2, 2, 50, DateTimeKind.Utc).AddTicks(3248), "Refrigerator with touch screen, interior cameras, and WiFi connectivity.", "https://via.placeholder.com/400x300.png?text=Smart+Refrigerator", "Smart Refrigerator", 1599.99m, 10 },
                    { new Guid("d7dee229-5f26-4c4d-bbf8-c94c37309c87"), 8, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 12, 2, 2, 50, DateTimeKind.Utc).AddTicks(3302), "Central hub to control and integrate all smart home devices.", "https://via.placeholder.com/400x300.png?text=Smart+Home+Hub", "Smart Home Hub", 129.99m, 40 },
                    { new Guid("e860c84f-d6b7-4a66-b15b-6eaaca830326"), 7, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 12, 2, 2, 50, DateTimeKind.Utc).AddTicks(3298), "Waterproof fitness tracker with heart rate monitor and sleep tracking.", "https://via.placeholder.com/400x300.png?text=Smart+Fitness+Tracker", "Smart Fitness Tracker", 59.99m, 120 },
                    { new Guid("f41dd764-b841-4bfb-ad34-6f8a01f145b2"), 9, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 12, 2, 2, 50, DateTimeKind.Utc).AddTicks(3327), "Weather-based sprinkler system for efficient garden watering.", "https://via.placeholder.com/400x300.png?text=Smart+Sprinkler+System", "Smart Sprinkler System", 199.99m, 20 }
                });
        }
    }
}

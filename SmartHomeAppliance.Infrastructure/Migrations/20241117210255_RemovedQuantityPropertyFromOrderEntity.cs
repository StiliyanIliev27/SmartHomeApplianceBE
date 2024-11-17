using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemovedQuantityPropertyFromOrderEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "051b0509-b62f-4f72-bb43-a16dac15400a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "12d4b899-7792-4ba2-a374-5ef20d601bdf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54039e75-ba32-405f-935e-44497b26d00f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "77664eab-93f4-4160-bbf6-818f6a964214");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7d61b9bc-6ea2-48c0-8821-e3d834b45fdf");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "84b6924f-73ba-48f4-bdf4-cc9879e575c2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8f8f0fbc-9fdd-4f37-803d-6b45403d307b");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b169c01a-49b9-4764-b241-f269fde92065");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d2f592aa-1ea8-4f69-8215-527e1b1a4412");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef8d09d3-6e9f-44a3-b7da-2b0fe9c641fe");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "414ac603-dbf2-499f-bdb6-5301aaa8a20d", "AQAAAAIAAYagAAAAEBZPFuBdU4/i4TauXi+h8/8PdBQsy88+q2d6nwKeQQfjLmzClwRI+3rJGirdsIHgtw==", "3ab64eca-3827-48dc-bc63-c36384924480" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatorId", "DateCreated", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { "6316fc90-c44e-455d-8c3b-85faf898b248", 6, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 21, 2, 54, 604, DateTimeKind.Utc).AddTicks(8825), "WiFi-enabled robot vacuum with auto-charge and scheduling capabilities.", "https://via.placeholder.com/400x300.png?text=Robot+Vacuum+Cleaner", "Robot Vacuum Cleaner", 299.99m, 75 },
                    { "6b85da6d-d92c-4a90-ba49-0661bb601c6e", 5, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 21, 2, 54, 604, DateTimeKind.Utc).AddTicks(8819), "Smart plug that monitors energy usage of connected devices in real-time.", "https://via.placeholder.com/400x300.png?text=Energy+Monitor+Plug", "Energy Monitor Plug", 24.99m, 200 },
                    { "78bc071a-113b-453d-80e7-8671a96340c9", 4, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 21, 2, 54, 604, DateTimeKind.Utc).AddTicks(8816), "Voice-activated smart speaker with high-fidelity sound and assistant integration.", "https://via.placeholder.com/400x300.png?text=Smart+Speaker", "Smart Speaker", 99.99m, 100 },
                    { "813a87ab-e9aa-47bb-a885-d6dbc8fdac51", 9, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 21, 2, 54, 604, DateTimeKind.Utc).AddTicks(8836), "Weather-based sprinkler system for efficient garden watering.", "https://via.placeholder.com/400x300.png?text=Smart+Sprinkler+System", "Smart Sprinkler System", 199.99m, 20 },
                    { "8740d9dc-8e4f-4af1-a7c6-30b05048c64c", 8, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 21, 2, 54, 604, DateTimeKind.Utc).AddTicks(8833), "Central hub to control and integrate all smart home devices.", "https://via.placeholder.com/400x300.png?text=Smart+Home+Hub", "Smart Home Hub", 129.99m, 40 },
                    { "918cff2a-ce3d-4190-8092-70c4f5f97f36", 7, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 21, 2, 54, 604, DateTimeKind.Utc).AddTicks(8829), "Waterproof fitness tracker with heart rate monitor and sleep tracking.", "https://via.placeholder.com/400x300.png?text=Smart+Fitness+Tracker", "Smart Fitness Tracker", 59.99m, 120 },
                    { "97ea27d6-a71b-41fb-ad71-d68474ffbefc", 1, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 21, 2, 54, 604, DateTimeKind.Utc).AddTicks(8788), "Color-changing LED light bulbs controllable via app or voice commands.", "https://via.placeholder.com/400x300.png?text=Smart+LED+Light+Bulbs", "Smart LED Light Bulbs (4-Pack)", 39.99m, 150 },
                    { "bf834fa6-b8f6-4cfd-a4c9-6d86fb9c25d2", 0, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 21, 2, 54, 604, DateTimeKind.Utc).AddTicks(8773), "A high-definition doorbell camera with night vision and motion detection.", "https://via.placeholder.com/400x300.png?text=Smart+Doorbell+Camera", "Smart Doorbell Camera", 129.99m, 50 },
                    { "c08c1eca-d41e-427d-b7b4-5aa94894cd88", 2, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 21, 2, 54, 604, DateTimeKind.Utc).AddTicks(8792), "A programmable thermostat that learns your heating and cooling preferences.", "https://via.placeholder.com/400x300.png?text=WiFi+Thermostat", "WiFi Thermostat", 249.99m, 30 },
                    { "c97d9288-f1fb-4701-8827-9867b8871ad6", 3, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 21, 2, 54, 604, DateTimeKind.Utc).AddTicks(8796), "Refrigerator with touch screen, interior cameras, and WiFi connectivity.", "https://via.placeholder.com/400x300.png?text=Smart+Refrigerator", "Smart Refrigerator", 1599.99m, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6316fc90-c44e-455d-8c3b-85faf898b248");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6b85da6d-d92c-4a90-ba49-0661bb601c6e");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "78bc071a-113b-453d-80e7-8671a96340c9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "813a87ab-e9aa-47bb-a885-d6dbc8fdac51");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8740d9dc-8e4f-4af1-a7c6-30b05048c64c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "918cff2a-ce3d-4190-8092-70c4f5f97f36");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "97ea27d6-a71b-41fb-ad71-d68474ffbefc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "bf834fa6-b8f6-4cfd-a4c9-6d86fb9c25d2");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c08c1eca-d41e-427d-b7b4-5aa94894cd88");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c97d9288-f1fb-4701-8827-9867b8871ad6");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fd43d87d-c638-49c3-8e25-31f8624784f8", "AQAAAAIAAYagAAAAECSvg5eRxtuBMx9zf+JbsDzdkZqApeWoc19t7AX1y+6f2a8qhUK9plzCpAMiTldApg==", "80191c10-30df-4d53-b400-4ad1ce2a878f" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatorId", "DateCreated", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { "051b0509-b62f-4f72-bb43-a16dac15400a", 8, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 20, 45, 48, 420, DateTimeKind.Utc).AddTicks(4156), "Central hub to control and integrate all smart home devices.", "https://via.placeholder.com/400x300.png?text=Smart+Home+Hub", "Smart Home Hub", 129.99m, 40 },
                    { "12d4b899-7792-4ba2-a374-5ef20d601bdf", 1, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 20, 45, 48, 420, DateTimeKind.Utc).AddTicks(3936), "Color-changing LED light bulbs controllable via app or voice commands.", "https://via.placeholder.com/400x300.png?text=Smart+LED+Light+Bulbs", "Smart LED Light Bulbs (4-Pack)", 39.99m, 150 },
                    { "54039e75-ba32-405f-935e-44497b26d00f", 4, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 20, 45, 48, 420, DateTimeKind.Utc).AddTicks(3996), "Voice-activated smart speaker with high-fidelity sound and assistant integration.", "https://via.placeholder.com/400x300.png?text=Smart+Speaker", "Smart Speaker", 99.99m, 100 },
                    { "77664eab-93f4-4160-bbf6-818f6a964214", 9, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 20, 45, 48, 420, DateTimeKind.Utc).AddTicks(4201), "Weather-based sprinkler system for efficient garden watering.", "https://via.placeholder.com/400x300.png?text=Smart+Sprinkler+System", "Smart Sprinkler System", 199.99m, 20 },
                    { "7d61b9bc-6ea2-48c0-8821-e3d834b45fdf", 7, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 20, 45, 48, 420, DateTimeKind.Utc).AddTicks(4148), "Waterproof fitness tracker with heart rate monitor and sleep tracking.", "https://via.placeholder.com/400x300.png?text=Smart+Fitness+Tracker", "Smart Fitness Tracker", 59.99m, 120 },
                    { "84b6924f-73ba-48f4-bdf4-cc9879e575c2", 2, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 20, 45, 48, 420, DateTimeKind.Utc).AddTicks(3942), "A programmable thermostat that learns your heating and cooling preferences.", "https://via.placeholder.com/400x300.png?text=WiFi+Thermostat", "WiFi Thermostat", 249.99m, 30 },
                    { "8f8f0fbc-9fdd-4f37-803d-6b45403d307b", 5, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 20, 45, 48, 420, DateTimeKind.Utc).AddTicks(4137), "Smart plug that monitors energy usage of connected devices in real-time.", "https://via.placeholder.com/400x300.png?text=Energy+Monitor+Plug", "Energy Monitor Plug", 24.99m, 200 },
                    { "b169c01a-49b9-4764-b241-f269fde92065", 6, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 20, 45, 48, 420, DateTimeKind.Utc).AddTicks(4143), "WiFi-enabled robot vacuum with auto-charge and scheduling capabilities.", "https://via.placeholder.com/400x300.png?text=Robot+Vacuum+Cleaner", "Robot Vacuum Cleaner", 299.99m, 75 },
                    { "d2f592aa-1ea8-4f69-8215-527e1b1a4412", 3, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 20, 45, 48, 420, DateTimeKind.Utc).AddTicks(3947), "Refrigerator with touch screen, interior cameras, and WiFi connectivity.", "https://via.placeholder.com/400x300.png?text=Smart+Refrigerator", "Smart Refrigerator", 1599.99m, 10 },
                    { "ef8d09d3-6e9f-44a3-b7da-2b0fe9c641fe", 0, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 20, 45, 48, 420, DateTimeKind.Utc).AddTicks(3913), "A high-definition doorbell camera with night vision and motion detection.", "https://via.placeholder.com/400x300.png?text=Smart+Doorbell+Camera", "Smart Doorbell Camera", 129.99m, 50 }
                });
        }
    }
}

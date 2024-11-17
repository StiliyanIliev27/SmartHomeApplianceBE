using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedCartTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Carts",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f86c6dfe-c642-423c-ac64-7a5339f9ffe4", "AQAAAAIAAYagAAAAEAnyEpz2KhdHmRNbzF09WyGtgD6GZP/VLRJXItGp8MHOtn5UVz4Rsr04EKtFrDVyjQ==", "340e68d8-915d-4d26-8ac4-ef03abfd79d6" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatorId", "DateCreated", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { new Guid("20be6808-ce7a-42ba-80bc-57f0488cd0ce"), 8, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 26, 10, 329, DateTimeKind.Utc).AddTicks(3917), "Central hub to control and integrate all smart home devices.", "https://via.placeholder.com/400x300.png?text=Smart+Home+Hub", "Smart Home Hub", 129.99m, 40 },
                    { new Guid("26f09448-efb5-49c0-b7ac-5a912ac07379"), 6, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 26, 10, 329, DateTimeKind.Utc).AddTicks(3909), "WiFi-enabled robot vacuum with auto-charge and scheduling capabilities.", "https://via.placeholder.com/400x300.png?text=Robot+Vacuum+Cleaner", "Robot Vacuum Cleaner", 299.99m, 75 },
                    { new Guid("635df46e-8d13-485a-bb2e-02c356697806"), 7, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 26, 10, 329, DateTimeKind.Utc).AddTicks(3913), "Waterproof fitness tracker with heart rate monitor and sleep tracking.", "https://via.placeholder.com/400x300.png?text=Smart+Fitness+Tracker", "Smart Fitness Tracker", 59.99m, 120 },
                    { new Guid("685d86ba-9506-4635-8942-99d54f3b1105"), 9, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 26, 10, 329, DateTimeKind.Utc).AddTicks(3919), "Weather-based sprinkler system for efficient garden watering.", "https://via.placeholder.com/400x300.png?text=Smart+Sprinkler+System", "Smart Sprinkler System", 199.99m, 20 },
                    { new Guid("6b524887-a567-47af-a87d-2d5ddba3103d"), 4, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 26, 10, 329, DateTimeKind.Utc).AddTicks(3906), "Voice-activated smart speaker with high-fidelity sound and assistant integration.", "https://via.placeholder.com/400x300.png?text=Smart+Speaker", "Smart Speaker", 99.99m, 100 },
                    { new Guid("9ce597c9-2179-4ac6-8301-4069b62b54fe"), 2, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 26, 10, 329, DateTimeKind.Utc).AddTicks(3875), "A programmable thermostat that learns your heating and cooling preferences.", "https://via.placeholder.com/400x300.png?text=WiFi+Thermostat", "WiFi Thermostat", 249.99m, 30 },
                    { new Guid("a4567afc-6f0b-4f81-8901-c6fb5e3877a0"), 1, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 26, 10, 329, DateTimeKind.Utc).AddTicks(3872), "Color-changing LED light bulbs controllable via app or voice commands.", "https://via.placeholder.com/400x300.png?text=Smart+LED+Light+Bulbs", "Smart LED Light Bulbs (4-Pack)", 39.99m, 150 },
                    { new Guid("b0a21c39-dbbf-4ac1-8d00-06b9071c8165"), 3, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 26, 10, 329, DateTimeKind.Utc).AddTicks(3877), "Refrigerator with touch screen, interior cameras, and WiFi connectivity.", "https://via.placeholder.com/400x300.png?text=Smart+Refrigerator", "Smart Refrigerator", 1599.99m, 10 },
                    { new Guid("b4ad6832-ea23-4ad0-be74-7533747bc382"), 0, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 26, 10, 329, DateTimeKind.Utc).AddTicks(3857), "A high-definition doorbell camera with night vision and motion detection.", "https://via.placeholder.com/400x300.png?text=Smart+Doorbell+Camera", "Smart Doorbell Camera", 129.99m, 50 },
                    { new Guid("e211b6e0-f8f8-4a5d-a78c-284befee5dfe"), 5, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 11, 17, 11, 26, 10, 329, DateTimeKind.Utc).AddTicks(3908), "Smart plug that monitors energy usage of connected devices in real-time.", "https://via.placeholder.com/400x300.png?text=Energy+Monitor+Plug", "Energy Monitor Plug", 24.99m, 200 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_AspNetUsers_UserId",
                table: "Carts");

            migrationBuilder.DropIndex(
                name: "IX_Carts_UserId",
                table: "Carts");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20be6808-ce7a-42ba-80bc-57f0488cd0ce"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26f09448-efb5-49c0-b7ac-5a912ac07379"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("635df46e-8d13-485a-bb2e-02c356697806"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("685d86ba-9506-4635-8942-99d54f3b1105"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("6b524887-a567-47af-a87d-2d5ddba3103d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("9ce597c9-2179-4ac6-8301-4069b62b54fe"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a4567afc-6f0b-4f81-8901-c6fb5e3877a0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b0a21c39-dbbf-4ac1-8d00-06b9071c8165"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b4ad6832-ea23-4ad0-be74-7533747bc382"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e211b6e0-f8f8-4a5d-a78c-284befee5dfe"));

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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
        }
    }
}

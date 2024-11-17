using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedIdToCartIdPropInCartTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Carts",
                newName: "CartId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.RenameColumn(
                name: "CartId",
                table: "Carts",
                newName: "Id");

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
        }
    }
}

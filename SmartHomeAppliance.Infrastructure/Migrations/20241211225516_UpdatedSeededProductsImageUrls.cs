using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedSeededProductsImageUrls : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59755b83-3706-4edf-870a-df326b58a674", "AQAAAAIAAYagAAAAECXFGe+Mu+Yw+5GMNrpFbMiaYjVWZ1E32Hpsn3GnwRCgcOhwopoNV0fTLrLRUQXB1w==", "12f1279f-e7d0-4c92-96e1-8475347f2e24" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatorId", "DateCreated", "Description", "ImageUrl", "Name", "Price", "StockQuantity" },
                values: new object[,]
                {
                    { "06c1cfcc-ef7a-453e-879b-a9249e8a67b9", 5, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(8058), "Smart plug that monitors energy usage of connected devices in real-time.", "https://static.independent.co.uk/2023/01/10/16/best%20energy%20monitors%20Indybest%20copy.jpg", "Energy Monitor Plug", 24.99m, 200 },
                    { "0eeb842b-f9a7-4e52-87db-4a69906dec4c", 8, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(8078), "Central hub to control and integrate all smart home devices.", "https://smartechdaily.com/wp-content/uploads/2024/05/19690_Generated_Image-1024x585.webp", "Smart Home Hub", 129.99m, 40 },
                    { "3c078fae-2a18-48cc-8d24-eccce0ced69c", 4, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(8049), "Voice-activated smart speaker with high-fidelity sound and assistant integration.", "https://cdn.aarp.net/content/dam/aarpe/en/home/home-family/personal-technology/info-2019/smart-speaker-uses/_jcr_content/root/container_main/container_body_main/container_body1/container_body_cf/container_image/articlecontentfragment/cfimage.coreimg.50.932.jpeg/content/dam/aarp/home-and-family/personal-technology/2019/10/1140-smart-speaker-functions.jpg", "Smart Speaker", 99.99m, 100 },
                    { "548ecd9a-dab3-4f00-9835-4084b47f3c07", 1, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(7978), "Color-changing LED light bulbs controllable via app or voice commands.", "https://cdn.shopify.com/s/files/1/0024/9803/5810/products/597853-Product-0-I-637940195577281576.jpg?v=1658439198", "Smart LED Light Bulbs (4-Pack)", 39.99m, 150 },
                    { "6578befc-6f3c-486e-83da-39b641c15336", 2, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(7984), "A programmable thermostat that learns your heating and cooling preferences.", "https://engocontrols.com/wp-content/uploads/2022/07/E901WIFI-2000x2000-1_strona_-min.png", "WiFi Thermostat", 249.99m, 30 },
                    { "670ebaec-49bb-4947-8bea-d466123d0af0", 0, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(7953), "A high-definition doorbell camera with night vision and motion detection.", "https://m.media-amazon.com/images/I/611pxr2ITgL.jpg", "Smart Doorbell Camera", 129.99m, 50 },
                    { "945bd2a5-b16c-45d7-a685-bde6bbf28fc0", 6, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(8063), "WiFi-enabled robot vacuum with auto-charge and scheduling capabilities.", "https://crowncleaners.org.uk/wp-content/uploads/2024/08/Robot_Vacuum_Cleaner-feature-image-blog.jpg", "Robot Vacuum Cleaner", 299.99m, 75 },
                    { "9b601fc3-89c8-4dc2-a5cc-58c805f426b4", 9, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(8298), "Weather-based sprinkler system for efficient garden watering.", "https://i.pcmag.com/imagery/reviews/05VIJDsjiZiHbe0MImRiYLr-1..v1569469978.jpg", "Smart Sprinkler System", 199.99m, 20 },
                    { "b084f708-534f-4400-94c8-8d5669cbb6c6", 7, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(8069), "Waterproof fitness tracker with heart rate monitor and sleep tracking.", "https://s13emagst.akamaized.net/products/62903/62902367/images/res_b892254d28f050b61467aa3472854e47.jpg", "Smart Fitness Tracker", 59.99m, 120 },
                    { "ef697ed7-40e6-4f0f-8df6-8f579b26a473", 3, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 11, 22, 55, 15, 512, DateTimeKind.Utc).AddTicks(8009), "Refrigerator with touch screen, interior cameras, and WiFi connectivity.", "https://www.lifewire.com/thmb/Ib9NmsHdQ4q236zqBVxnsNYTIHA=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/samsung-ha-ref-rf56k9540sr-family-hub-overview-5aa18f0e18ba010037c023a5.jpg", "Smart Refrigerator", 1599.99m, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "06c1cfcc-ef7a-453e-879b-a9249e8a67b9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "0eeb842b-f9a7-4e52-87db-4a69906dec4c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "3c078fae-2a18-48cc-8d24-eccce0ced69c");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "548ecd9a-dab3-4f00-9835-4084b47f3c07");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "6578befc-6f3c-486e-83da-39b641c15336");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "670ebaec-49bb-4947-8bea-d466123d0af0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "945bd2a5-b16c-45d7-a685-bde6bbf28fc0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "9b601fc3-89c8-4dc2-a5cc-58c805f426b4");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b084f708-534f-4400-94c8-8d5669cbb6c6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "ef697ed7-40e6-4f0f-8df6-8f579b26a473");

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
    }
}

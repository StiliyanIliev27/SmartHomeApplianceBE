using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedRatingPropertyToProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "24b5a8e7-1634-45e7-a3d5-85cc0c16b1f2", "AQAAAAIAAYagAAAAEHv+Y9Tr6eB372E/btEHPy1UDUOOCRclC+ZulYUKnyBYFW6P1vJhvV45jElo85hwQw==", "a02eea18-09bc-45ac-8e9c-928a33910cc4" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatorId", "DateCreated", "Description", "ImageUrl", "Name", "Price", "Rating", "StockQuantity" },
                values: new object[,]
                {
                    { "49393fd1-eee0-4222-8264-2f21a0074a6f", 0, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 20, 12, 38, 43, 348, DateTimeKind.Utc).AddTicks(2359), "A high-definition doorbell camera with night vision and motion detection.", "https://m.media-amazon.com/images/I/611pxr2ITgL.jpg", "Smart Doorbell Camera", 129.99m, 4, 50 },
                    { "523a5fa0-d6d2-4595-9fec-90dcbef1f47a", 5, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 20, 12, 38, 43, 348, DateTimeKind.Utc).AddTicks(2417), "Smart plug that monitors energy usage of connected devices in real-time.", "https://static.independent.co.uk/2023/01/10/16/best%20energy%20monitors%20Indybest%20copy.jpg", "Energy Monitor Plug", 24.99m, 5, 200 },
                    { "7285ce02-49de-437b-8b7c-150980f09e42", 1, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 20, 12, 38, 43, 348, DateTimeKind.Utc).AddTicks(2378), "Color-changing LED light bulbs controllable via app or voice commands.", "https://cdn.shopify.com/s/files/1/0024/9803/5810/products/597853-Product-0-I-637940195577281576.jpg?v=1658439198", "Smart LED Light Bulbs (4-Pack)", 39.99m, 5, 150 },
                    { "72896bb4-e923-4273-959c-15b316d73542", 6, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 20, 12, 38, 43, 348, DateTimeKind.Utc).AddTicks(2426), "WiFi-enabled robot vacuum with auto-charge and scheduling capabilities.", "https://crowncleaners.org.uk/wp-content/uploads/2024/08/Robot_Vacuum_Cleaner-feature-image-blog.jpg", "Robot Vacuum Cleaner", 299.99m, 5, 75 },
                    { "8155e5a6-dbd6-4b5f-81a9-1bec2bfa4f26", 2, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 20, 12, 38, 43, 348, DateTimeKind.Utc).AddTicks(2383), "A programmable thermostat that learns your heating and cooling preferences.", "https://engocontrols.com/wp-content/uploads/2022/07/E901WIFI-2000x2000-1_strona_-min.png", "WiFi Thermostat", 249.99m, 4, 30 },
                    { "8661c249-f434-46fa-a7b1-8139de94952f", 9, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 20, 12, 38, 43, 348, DateTimeKind.Utc).AddTicks(2440), "Weather-based sprinkler system for efficient garden watering.", "https://i.pcmag.com/imagery/reviews/05VIJDsjiZiHbe0MImRiYLr-1..v1569469978.jpg", "Smart Sprinkler System", 199.99m, 2, 20 },
                    { "a7416dc2-92c3-41af-bcca-0898fc4c56a8", 4, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 20, 12, 38, 43, 348, DateTimeKind.Utc).AddTicks(2413), "Voice-activated smart speaker with high-fidelity sound and assistant integration.", "https://cdn.aarp.net/content/dam/aarpe/en/home/home-family/personal-technology/info-2019/smart-speaker-uses/_jcr_content/root/container_main/container_body_main/container_body1/container_body_cf/container_image/articlecontentfragment/cfimage.coreimg.50.932.jpeg/content/dam/aarp/home-and-family/personal-technology/2019/10/1140-smart-speaker-functions.jpg", "Smart Speaker", 99.99m, 4, 100 },
                    { "dc75b2fe-b5d0-435e-9926-0e1113283c7d", 7, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 20, 12, 38, 43, 348, DateTimeKind.Utc).AddTicks(2430), "Waterproof fitness tracker with heart rate monitor and sleep tracking.", "https://s13emagst.akamaized.net/products/62903/62902367/images/res_b892254d28f050b61467aa3472854e47.jpg", "Smart Fitness Tracker", 59.99m, 4, 120 },
                    { "e6c742c5-a928-4da6-875a-d13b0c1fd504", 8, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 20, 12, 38, 43, 348, DateTimeKind.Utc).AddTicks(2436), "Central hub to control and integrate all smart home devices.", "https://smartechdaily.com/wp-content/uploads/2024/05/19690_Generated_Image-1024x585.webp", "Smart Home Hub", 129.99m, 3, 40 },
                    { "fc65364a-8712-4400-8918-ded0d6f4b3a5", 3, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 20, 12, 38, 43, 348, DateTimeKind.Utc).AddTicks(2388), "Refrigerator with touch screen, interior cameras, and WiFi connectivity.", "https://www.lifewire.com/thmb/Ib9NmsHdQ4q236zqBVxnsNYTIHA=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/samsung-ha-ref-rf56k9540sr-family-hub-overview-5aa18f0e18ba010037c023a5.jpg", "Smart Refrigerator", 1599.99m, 3, 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "49393fd1-eee0-4222-8264-2f21a0074a6f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "523a5fa0-d6d2-4595-9fec-90dcbef1f47a");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7285ce02-49de-437b-8b7c-150980f09e42");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "72896bb4-e923-4273-959c-15b316d73542");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8155e5a6-dbd6-4b5f-81a9-1bec2bfa4f26");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "8661c249-f434-46fa-a7b1-8139de94952f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a7416dc2-92c3-41af-bcca-0898fc4c56a8");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "dc75b2fe-b5d0-435e-9926-0e1113283c7d");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "e6c742c5-a928-4da6-875a-d13b0c1fd504");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "fc65364a-8712-4400-8918-ded0d6f4b3a5");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Products");

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
    }
}

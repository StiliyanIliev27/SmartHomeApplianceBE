using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedMoreSeedDataToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3a6b4eb-ddf7-47ea-8b1e-06993fa6710d", "AQAAAAIAAYagAAAAEIsj6U3iHY9LyZDXz965+ZztigL7kTR2CHMKEbZb9lNIj/2jtlKmgWxIB1kAuq2NKg==", "ad4b8b93-f2cd-4404-883d-ca78fae7c125" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "11223344-5566-7788-99aa-bbccddeeff00", 0, "d400eec8-c41d-4b19-804e-22e7b363cb8c", "moderator@smarthomeapp.bg", true, "Mod", "Erator", false, null, "MODERATOR@SMARTHOMEAPP.BG", null, "AQAAAAIAAYagAAAAENnRFRcKxEnpsLxQ3CzO1okdjlJUQGRFHKkdQ2YMl8uEOIcicbCsZYPWxx3YchlBkA==", null, false, "https://images.unsplash.com/photo-1534528741775-53994a69daeb", "28d51c9c-eaf0-471c-9734-038744476b29", false, null },
                    { "12345678-9abc-def0-1234-56789abcdef0", 0, "63ad0394-0413-4e27-a273-58b74e19fd6e", "john.doe@example.com", true, "John", "Doe", false, null, "JOHN.DOE@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEJ5nhuCWQozo4kkFRBU2qwwr7rLBcfAbvVjMh9Wnyi+uZutxlTLdzu2K1wk4FM879w==", null, false, "https://images.unsplash.com/photo-1502720705749-3c53d2b6dc34", "63ea1173-d0cd-49c3-a4a9-2f9d85826f29", false, null },
                    { "abcdef12-3456-7890-abcd-ef1234567890", 0, "d0fa79f2-bce4-4709-b378-617e89f42560", "jane.smith@example.com", true, "Jane", "Smith", false, null, "JANE.SMITH@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEAk0AH7nRiWfW092vZCxsprdS1d9Hi0MA9IJssnQkyw1rpOS175Ogg2NuLj4EuaM9g==", null, false, "https://images.unsplash.com/photo-1511367461989-f85a21fda167", "fd7f82ee-53e9-45b6-bafa-e441f9c294e3", false, null },
                    { "fedcba98-7654-3210-fedc-ba9876543210", 0, "e735dd9f-a26b-489a-9c69-a8394c7dd5e6", "guest@example.com", false, "Guest", "User", false, null, "GUEST@EXAMPLE.COM", null, "AQAAAAIAAYagAAAAEGVLhdjRoP8jAHUp9TFqPJxGSz4me2q8FUZuCdhMdfQ2EJqW7L6GppTkXEYmVJ4M2A==", null, false, "https://images.unsplash.com/photo-1529626455594-4ff0802cfb7e", "31473c00-d005-4492-976e-7537699fff67", false, null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "CreatorId", "DateCreated", "Description", "ImageUrl", "Name", "Price", "Rating", "StockQuantity" },
                values: new object[,]
                {
                    { "398a846c-2b2c-4b01-90f2-55d342268673", 9, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5894), "Weather-based sprinkler system for efficient garden watering.", "https://i.pcmag.com/imagery/reviews/05VIJDsjiZiHbe0MImRiYLr-1..v1569469978.jpg", "Smart Sprinkler System", 199.99m, 2, 20 },
                    { "40941ea9-019c-415c-a101-9ccbc93a07d6", 2, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5836), "A programmable thermostat that learns your heating and cooling preferences.", "https://engocontrols.com/wp-content/uploads/2022/07/E901WIFI-2000x2000-1_strona_-min.png", "WiFi Thermostat", 249.99m, 4, 30 },
                    { "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5850), "Refrigerator with touch screen, interior cameras, and WiFi connectivity.", "https://www.lifewire.com/thmb/Ib9NmsHdQ4q236zqBVxnsNYTIHA=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/samsung-ha-ref-rf56k9540sr-family-hub-overview-5aa18f0e18ba010037c023a5.jpg", "Smart Refrigerator", 1599.99m, 3, 10 },
                    { "668c6a85-f13f-43e9-b898-64d210b1cd45", 6, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5879), "WiFi-enabled robot vacuum with auto-charge and scheduling capabilities.", "https://crowncleaners.org.uk/wp-content/uploads/2024/08/Robot_Vacuum_Cleaner-feature-image-blog.jpg", "Robot Vacuum Cleaner", 299.99m, 5, 75 },
                    { "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 7, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5883), "Waterproof fitness tracker with heart rate monitor and sleep tracking.", "https://s13emagst.akamaized.net/products/62903/62902367/images/res_b892254d28f050b61467aa3472854e47.jpg", "Smart Fitness Tracker", 59.99m, 4, 120 },
                    { "800a6ca2-3027-4a0f-ae72-0156405a6a58", 4, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5857), "Voice-activated smart speaker with high-fidelity sound and assistant integration.", "https://cdn.aarp.net/content/dam/aarpe/en/home/home-family/personal-technology/info-2019/smart-speaker-uses/_jcr_content/root/container_main/container_body_main/container_body1/container_body_cf/container_image/articlecontentfragment/cfimage.coreimg.50.932.jpeg/content/dam/aarp/home-and-family/personal-technology/2019/10/1140-smart-speaker-functions.jpg", "Smart Speaker", 99.99m, 4, 100 },
                    { "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5861), "Smart plug that monitors energy usage of connected devices in real-time.", "https://static.independent.co.uk/2023/01/10/16/best%20energy%20monitors%20Indybest%20copy.jpg", "Energy Monitor Plug", 24.99m, 5, 200 },
                    { "b109e70a-6b64-489f-a216-1d407abcf02f", 8, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5890), "Central hub to control and integrate all smart home devices.", "https://smartechdaily.com/wp-content/uploads/2024/05/19690_Generated_Image-1024x585.webp", "Smart Home Hub", 129.99m, 3, 40 },
                    { "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 0, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5818), "A high-definition doorbell camera with night vision and motion detection.", "https://m.media-amazon.com/images/I/611pxr2ITgL.jpg", "Smart Doorbell Camera", 129.99m, 4, 50 },
                    { "d39a7ae3-78c5-40ae-8569-34a0454dc909", 1, "27d78708-8671-4b05-bd5e-17aa91392224", new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5830), "Color-changing LED light bulbs controllable via app or voice commands.", "https://cdn.shopify.com/s/files/1/0024/9803/5810/products/597853-Product-0-I-637940195577281576.jpg?v=1658439198", "Smart LED Light Bulbs (4-Pack)", 39.99m, 5, 150 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11223344-5566-7788-99aa-bbccddeeff00");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "398a846c-2b2c-4b01-90f2-55d342268673");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40941ea9-019c-415c-a101-9ccbc93a07d6");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54a7eca8-ed42-4444-8522-d5a00310ed62");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "668c6a85-f13f-43e9-b898-64d210b1cd45");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7be0663a-6953-44a8-9d06-80f1d72ce6b3");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "800a6ca2-3027-4a0f-ae72-0156405a6a58");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2fa3f78-c2ce-44ae-8b3f-402f54563b30");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b109e70a-6b64-489f-a216-1d407abcf02f");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d39a7ae3-78c5-40ae-8569-34a0454dc909");

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
    }
}

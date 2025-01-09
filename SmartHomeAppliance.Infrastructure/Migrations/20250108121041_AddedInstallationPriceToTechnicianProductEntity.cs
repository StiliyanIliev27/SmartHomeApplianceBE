using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedInstallationPriceToTechnicianProductEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "19a3b5e2-7a3c-4488-84e5-cbe6c5177833");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "262279a9-918a-4779-a74a-f87139df9edd");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "2bd8ceca-ab7d-40ae-a3d0-2eb9c77d4a2c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "2c0098c5-1a2b-4874-824b-baa42e489531");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "2f94dbfd-484f-4f7c-b72b-d6e576406702");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "350a0a67-e525-4d1d-8f28-835ca60942fb");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "359f993d-9318-42f3-8fe8-0d27db5928d3");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "3a121b26-8e73-4e72-a5d7-5acab2f56711");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "3a41fa03-9fa3-46d2-a976-fbb6dc8de611");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "55d68a8a-0629-409e-8d1d-ff25b7c1aaba");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "5a05282d-bb89-4e15-92df-15623bbf7ad4");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "5c76e313-10ed-4e55-b8c1-e2e4007bb8c6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "623d2da4-4751-4c58-917f-2ae342735b24");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "6d457590-08ab-4a67-85fe-cda6f97cda6a");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "78f89e36-319a-4a26-b4ad-bb5830249dd1");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "8d1aaedb-fc22-416f-837f-b8d90c0fb682");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "9311fc29-9d0c-4b75-abe8-507431ee9378");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "9994f084-1551-4566-a6d3-42e2e233f7a6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "a31ce277-b597-4d6f-9bfa-f2902461fc33");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b1232d5a-1e7f-4217-8641-b6915e6f2b5f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b2124285-7236-498f-8794-a7d9db28d4d6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b64a8d71-ed2d-45cf-92f4-17c5ba4f2c6f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "be385e62-fcb6-4567-9c64-f51b8c18d0d7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "c6085d88-2996-421e-bb7e-0f990794c30e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "fed1a713-de55-4538-83f6-dcf84973ab28");

            migrationBuilder.AddColumn<decimal>(
                name: "InstallationPrice",
                table: "TechniciansProducts",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11223344-5566-7788-99aa-bbccddeeff00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4acefc67-546f-418e-81b6-ec10295ef9e3", "AQAAAAIAAYagAAAAEOsubUtXWsKUocjWO22ggAOERS/ZGSluBH6SqxFXCPM48Hd3Va9D6QUbOiXxXNmWmQ==", "cd6d26c9-34b9-4274-b2ae-99d950c8a1a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dba3bf0-160a-4f95-8898-6cd95fb578c8", "AQAAAAIAAYagAAAAEJIdtlQXTvkh39V9UAsPuTpPqwGdhPyDchpFBLb8iVyjpTK0RlnuupPuLvJ8hTiRUA==", "280f3361-0faf-4829-81c8-387efec60fd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c38d05ca-a49a-4a1f-900b-ec004d9e2b41", "AQAAAAIAAYagAAAAEPz4SlWFYPkqEmXiQtGP85EO4I8K2jRC48Zz5jexmwDrSGEgRTLpvJGRTDoVSATd4w==", "36526246-2176-4d1b-8221-25869e9ac630" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76046da4-7eb4-4e53-8838-54c0af565e39", "AQAAAAIAAYagAAAAEJFbCqgZ4dCJocCgIQHDAOzEKNBGeFJSse10wGj9V8b89hIi8T+DcyogXqDRdrCcZA==", "e9659a4e-5fd3-4f01-a1cb-cf310fe540d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2919413f-1944-478a-9375-68885c8ce21e", "AQAAAAIAAYagAAAAEMGIVE5VMVK5aqLqKU4O71a2c/arnHutA2UCWitldV5rU0On/UxT6XxWCOJRi6ZANQ==", "f5c39607-8e04-47b2-8730-1e44a27ad171" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "398a846c-2b2c-4b01-90f2-55d342268673",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40941ea9-019c-415c-a101-9ccbc93a07d6",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54a7eca8-ed42-4444-8522-d5a00310ed62",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "668c6a85-f13f-43e9-b898-64d210b1cd45",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "800a6ca2-3027-4a0f-ae72-0156405a6a58",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b109e70a-6b64-489f-a216-1d407abcf02f",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { "23f50cb0-1b21-4d71-824b-4bfe3fdaa104", "The hub has some lag when controlling multiple devices.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 9, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8057), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "30b3701f-02bb-41da-b815-e3b2cdad50b4", "The lights are fantastic, and the app is super intuitive.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2025, 1, 1, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8066), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "3159d948-f326-47ab-8e32-6b8c0ab3913d", "Good hub, but it doesn't support some devices I own.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 21, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8088), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "4aeed923-3355-4fe3-9496-74c1eb276c15", "Simple to use and very informative. A must-have for saving energy.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 9, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8092), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "4bed9d30-a191-4001-b4eb-1893f235407e", "The sprinkler system works well, but setup was confusing.", "398a846c-2b2c-4b01-90f2-55d342268673", 4, new DateTime(2024, 12, 17, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8090), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "4d6dc680-957b-421e-b63f-2e1d788ddd35", "Easy to install and very efficient for garden watering.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 30, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8072), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "61f91ea8-46e8-427d-9cd8-7e0320e113a0", "This vacuum cleaner has saved me so much time. Highly recommend!", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 31, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8084), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "6a714165-94b8-44ff-8b0b-c9a3a7f40779", "I saved so much energy with this plug. The real-time monitoring is awesome.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 21, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8050), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "6b439061-63b9-4631-9641-69bb0b7f764e", "The weather-based feature works like a charm for my garden.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 31, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8054), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "93487c7a-506b-4089-93cd-90471bd0babc", "The robot vacuum works well on carpets and tiles but struggles with edges.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 4, new DateTime(2024, 12, 27, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8048), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "adca0d27-43f5-48d4-9f9c-51f8d363fa36", "Great for tracking my workouts, but the strap feels a bit cheap.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 27, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8086), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "b3974467-aae5-4d5d-8341-eb78afda334a", "A must-have fitness tracker for anyone serious about health.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 5, new DateTime(2024, 12, 19, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8038), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "bbf27d0e-360c-4ee5-98f1-d1bae28c31e9", "Fun to use and great for parties! The color-changing feature is amazing.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2025, 1, 3, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8043), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "c380984c-a10b-4722-a2b0-dda837ad5865", "This doorbell camera works great! The motion detection is very accurate.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 29, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8074), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "ce918b4d-4fd2-4b60-9b32-b3cdf44f055c", "Accurate sleep tracking, but the battery life is shorter than expected.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 28, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8068), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "ceda02e1-209d-483b-b8c6-9df6c8d82182", "Perfect for busy people. It cleans thoroughly and docks automatically.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 19, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8061), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "cf9b662d-b797-44ec-841b-990f7cc3b6e7", "The lights are very bright and the app is easy to use.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 4, new DateTime(2024, 12, 19, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8076), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "d72f6fbc-7b87-4ea1-80c1-186fdc84c83c", "Works well for basic needs, but advanced users may want more features.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 23, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8070), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "e3b98e03-3613-4e73-ad00-9b707f937ae0", "This thermostat was a game-changer for our energy bills.", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 14, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8052), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "eb26646e-7739-4026-9037-a751664a69cb", "I love how easy it is to set up this doorbell camera. The image quality is superb.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 29, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8031), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "ed60ed6c-0904-4f2d-8df5-1940cf4c7dda", "The night vision is good, but the motion detection can be too sensitive.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 4, new DateTime(2024, 12, 25, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8059), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "f3116a04-459e-426f-bf8e-57b1a8d120f8", "The screen is impressive, but the cooling performance could be better.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2025, 1, 3, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8082), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "f3b39011-fdcd-4e20-a7ea-de003bd93f47", "The refrigerator is sleek, but I think it's overpriced for the features.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 24, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8036), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "fd2d8593-d13f-4642-9cd9-20627f8dd8b9", "A bit pricey, but I love how it learns my preferences!", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 24, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8079), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "fdf3aaad-102e-4ba8-a18c-9c9cb359610f", "Great design, but I wish the touch screen was more responsive.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 4, new DateTime(2024, 12, 17, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8064), "11223344-5566-7788-99aa-bbccddeeff00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "23f50cb0-1b21-4d71-824b-4bfe3fdaa104");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "30b3701f-02bb-41da-b815-e3b2cdad50b4");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "3159d948-f326-47ab-8e32-6b8c0ab3913d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "4aeed923-3355-4fe3-9496-74c1eb276c15");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "4bed9d30-a191-4001-b4eb-1893f235407e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "4d6dc680-957b-421e-b63f-2e1d788ddd35");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "61f91ea8-46e8-427d-9cd8-7e0320e113a0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "6a714165-94b8-44ff-8b0b-c9a3a7f40779");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "6b439061-63b9-4631-9641-69bb0b7f764e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "93487c7a-506b-4089-93cd-90471bd0babc");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "adca0d27-43f5-48d4-9f9c-51f8d363fa36");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b3974467-aae5-4d5d-8341-eb78afda334a");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "bbf27d0e-360c-4ee5-98f1-d1bae28c31e9");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "c380984c-a10b-4722-a2b0-dda837ad5865");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ce918b4d-4fd2-4b60-9b32-b3cdf44f055c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ceda02e1-209d-483b-b8c6-9df6c8d82182");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "cf9b662d-b797-44ec-841b-990f7cc3b6e7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "d72f6fbc-7b87-4ea1-80c1-186fdc84c83c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "e3b98e03-3613-4e73-ad00-9b707f937ae0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "eb26646e-7739-4026-9037-a751664a69cb");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ed60ed6c-0904-4f2d-8df5-1940cf4c7dda");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f3116a04-459e-426f-bf8e-57b1a8d120f8");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f3b39011-fdcd-4e20-a7ea-de003bd93f47");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "fd2d8593-d13f-4642-9cd9-20627f8dd8b9");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "fdf3aaad-102e-4ba8-a18c-9c9cb359610f");

            migrationBuilder.DropColumn(
                name: "InstallationPrice",
                table: "TechniciansProducts");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11223344-5566-7788-99aa-bbccddeeff00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5c96159-1e88-4f9f-b39e-23a430aef505", "AQAAAAIAAYagAAAAEAg0sga5P0LyNvTn5JFxhYT7ymq9fiH7Hn+unN9/YXrvNtP81u4BFpNggzIM80GLDw==", "559c9f84-d152-49b0-9fcf-ac964b52fcb9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0fd829c-bad1-4849-bd5a-7c0d55f64b93", "AQAAAAIAAYagAAAAEF52XHqacqNTmgZuNUVxygTE9fAJtuqlbgFLsis3/qL/FMMRQEtKUpKQRcUHbNVjQQ==", "63f846ff-d80b-4ebf-a6e9-76ebf85b926d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22da9a74-94ef-4e84-934a-404abfb6af86", "AQAAAAIAAYagAAAAEEp2SS42vhsVd1tQs75e83rg1jhmIjzk+f1M88RWOQC3oZfY/mvSO5sZ+CGjYmnxlA==", "30adc6f1-a1f8-48a8-88b0-88ed520f30d2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebea3cee-f046-43c6-a391-33d06a722085", "AQAAAAIAAYagAAAAEEUb20WX3eIaTHKzoafz+UMv89CTI8oTn8EdtW+jcyDYnlsQhoqMtBLL66LKbgZvhw==", "f5b5804a-fcae-4941-b7e2-8e86137726e7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9fb1d78-a604-40bb-b667-cd12a4089aa8", "AQAAAAIAAYagAAAAEEhSclxpNb+vJBJvIthvBSgALhb68mR6WjWYuqmBvA3DEBeN9X3RbUerCCF6XG+Uuw==", "29e324a2-11ed-47f6-b84f-73b448b2a8cc" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "398a846c-2b2c-4b01-90f2-55d342268673",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 4, 55, 730, DateTimeKind.Utc).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40941ea9-019c-415c-a101-9ccbc93a07d6",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 4, 55, 730, DateTimeKind.Utc).AddTicks(3530));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54a7eca8-ed42-4444-8522-d5a00310ed62",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 4, 55, 730, DateTimeKind.Utc).AddTicks(3534));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "668c6a85-f13f-43e9-b898-64d210b1cd45",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 4, 55, 730, DateTimeKind.Utc).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 4, 55, 730, DateTimeKind.Utc).AddTicks(3568));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "800a6ca2-3027-4a0f-ae72-0156405a6a58",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 4, 55, 730, DateTimeKind.Utc).AddTicks(3556));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 4, 55, 730, DateTimeKind.Utc).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b109e70a-6b64-489f-a216-1d407abcf02f",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 4, 55, 730, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 4, 55, 730, DateTimeKind.Utc).AddTicks(3510));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 4, 55, 730, DateTimeKind.Utc).AddTicks(3526));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { "19a3b5e2-7a3c-4488-84e5-cbe6c5177833", "Good hub, but it doesn't support some devices I own.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 21, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(36), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "262279a9-918a-4779-a74a-f87139df9edd", "Accurate sleep tracking, but the battery life is shorter than expected.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 28, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(15), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "2bd8ceca-ab7d-40ae-a3d0-2eb9c77d4a2c", "Great design, but I wish the touch screen was more responsive.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 4, new DateTime(2024, 12, 17, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(12), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "2c0098c5-1a2b-4874-824b-baa42e489531", "This thermostat was a game-changer for our energy bills.", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 14, 12, 4, 56, 73, DateTimeKind.Utc).AddTicks(9999), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "2f94dbfd-484f-4f7c-b72b-d6e576406702", "The sprinkler system works well, but setup was confusing.", "398a846c-2b2c-4b01-90f2-55d342268673", 4, new DateTime(2024, 12, 17, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(37), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "350a0a67-e525-4d1d-8f28-835ca60942fb", "The refrigerator is sleek, but I think it's overpriced for the features.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 24, 12, 4, 56, 73, DateTimeKind.Utc).AddTicks(9985), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "359f993d-9318-42f3-8fe8-0d27db5928d3", "Great for tracking my workouts, but the strap feels a bit cheap.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 27, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(34), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "3a121b26-8e73-4e72-a5d7-5acab2f56711", "A must-have fitness tracker for anyone serious about health.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 5, new DateTime(2024, 12, 19, 12, 4, 56, 73, DateTimeKind.Utc).AddTicks(9988), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "3a41fa03-9fa3-46d2-a976-fbb6dc8de611", "Works well for basic needs, but advanced users may want more features.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 23, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(17), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "55d68a8a-0629-409e-8d1d-ff25b7c1aaba", "Easy to install and very efficient for garden watering.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 30, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(19), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "5a05282d-bb89-4e15-92df-15623bbf7ad4", "A bit pricey, but I love how it learns my preferences!", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 24, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(27), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "5c76e313-10ed-4e55-b8c1-e2e4007bb8c6", "I love how easy it is to set up this doorbell camera. The image quality is superb.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 29, 12, 4, 56, 73, DateTimeKind.Utc).AddTicks(9981), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "623d2da4-4751-4c58-917f-2ae342735b24", "Fun to use and great for parties! The color-changing feature is amazing.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2025, 1, 3, 12, 4, 56, 73, DateTimeKind.Utc).AddTicks(9992), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "6d457590-08ab-4a67-85fe-cda6f97cda6a", "The weather-based feature works like a charm for my garden.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 31, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(2), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "78f89e36-319a-4a26-b4ad-bb5830249dd1", "The hub has some lag when controlling multiple devices.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 9, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(4), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "8d1aaedb-fc22-416f-837f-b8d90c0fb682", "The lights are fantastic, and the app is super intuitive.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2025, 1, 1, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(14), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "9311fc29-9d0c-4b75-abe8-507431ee9378", "The screen is impressive, but the cooling performance could be better.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2025, 1, 3, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(30), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "9994f084-1551-4566-a6d3-42e2e233f7a6", "This doorbell camera works great! The motion detection is very accurate.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 29, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(21), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "a31ce277-b597-4d6f-9bfa-f2902461fc33", "The robot vacuum works well on carpets and tiles but struggles with edges.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 4, new DateTime(2024, 12, 27, 12, 4, 56, 73, DateTimeKind.Utc).AddTicks(9995), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "b1232d5a-1e7f-4217-8641-b6915e6f2b5f", "Perfect for busy people. It cleans thoroughly and docks automatically.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 19, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(8), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "b2124285-7236-498f-8794-a7d9db28d4d6", "The night vision is good, but the motion detection can be too sensitive.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 4, new DateTime(2024, 12, 25, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(6), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "b64a8d71-ed2d-45cf-92f4-17c5ba4f2c6f", "The lights are very bright and the app is easy to use.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 4, new DateTime(2024, 12, 19, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(23), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "be385e62-fcb6-4567-9c64-f51b8c18d0d7", "I saved so much energy with this plug. The real-time monitoring is awesome.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 21, 12, 4, 56, 73, DateTimeKind.Utc).AddTicks(9997), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "c6085d88-2996-421e-bb7e-0f990794c30e", "Simple to use and very informative. A must-have for saving energy.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 9, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(39), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "fed1a713-de55-4538-83f6-dcf84973ab28", "This vacuum cleaner has saved me so much time. Highly recommend!", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 31, 12, 4, 56, 74, DateTimeKind.Utc).AddTicks(32), "12345678-9abc-def0-1234-56789abcdef0" }
                });
        }
    }
}

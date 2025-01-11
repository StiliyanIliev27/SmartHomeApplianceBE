using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedOrderStatusToOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "00b06dc2-faa4-41f7-9668-acc8577b30bd");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "04d39568-01d4-4da2-859a-cd5ccb239d17");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "05f0c71b-504f-4499-bf48-2001090c9659");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "2d37164c-ebe5-4eef-9e84-c58486d61210");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "300f52d2-f044-4c0c-b174-691ccf380180");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "4215b968-3171-4bc4-94a0-efee5ac2e7be");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "54bf2262-e52f-4711-b26f-e9498636f337");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "5dc360bf-46d8-45b1-937b-91ae7d762c5e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "726f6524-0f1c-48c5-b804-b43e4040fce0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "7dec038c-67b1-457c-981f-b2b896c6dfa2");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "84cb92f0-ec89-49bb-850b-d3591d7479ab");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "8e68ac92-c9f9-4007-909f-d0e2596d6a6c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "9080907d-14c2-4841-b697-e73adc782ca9");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ab517a04-d7bc-4aea-8702-d34b6d8eadb2");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ad9032a9-bfdf-4dd9-ba2c-7d03c3b986cd");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b7021282-bf60-4d41-8df1-6d6c30fb056e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "bac15b53-c541-4fa8-9a66-02dce7cca058");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "bc815757-77d3-4644-b703-54730ec63750");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "bde2e996-85bf-49a3-9df5-1b9f82c8dfe4");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "c0139545-e69f-421a-8fe5-12c5d145cfb2");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "c47aa578-7252-4dc5-aba9-427284f955b8");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "c81b6219-1afa-462f-9d67-8d69e28c4767");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "e5d3de76-505b-42a2-84d8-b1a7fcbfebd6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ea0e4368-e9eb-4ba5-8962-248cf9547360");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f6953bbb-db92-4c95-9cab-48bd26727268");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Orders",
                newName: "PaymentStatus");

            migrationBuilder.AddColumn<int>(
                name: "OrderStatus",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11223344-5566-7788-99aa-bbccddeeff00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e4fbd19-c9cb-449f-b9d5-5b752489bfae", "AQAAAAIAAYagAAAAEGmO0xCiAAbUR5tOYDzgol33M3r7ARIh/VMd3f8WgFcb2Eh4Veaso7NwOUBXCDO8kQ==", "58abaa39-15a2-4e9b-8ed0-776ee51e4a8c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ba9829df-a104-4300-b391-a6ea889009d0", "AQAAAAIAAYagAAAAEHEwtQnULkCoD5avEEvDqLus8g8hGeYQJ/btEaFQLN3qWlibw+yxdF4tjGzBtbADEw==", "92b6e724-c117-4c7b-9ac8-4927ccc996aa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "02b4e5b0-c4ba-48e3-8453-4056d4d9b57a", "AQAAAAIAAYagAAAAEFLgTWOq9XR5GZZGarrviV13HZy3lR8DSjXU6uKXv4dBgXuPwYt5RFv6c0jXNATi5Q==", "4020fab8-c244-476b-a1bc-395e05ac764b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "db0551de-4fe5-4734-bce5-cf3eab4733ae", "AQAAAAIAAYagAAAAEMw2L081kB8Il8sbZTT969fa8vbDtn+Kj2mSHqL35kkj0N31akFYUz3ILxA2BmBC6Q==", "7590f318-f4a5-4659-9ba1-8dcee37e4255" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bea1c5f3-ede5-482f-a9b2-112700dfaf82", "AQAAAAIAAYagAAAAEFTSSA4QGqHZIdat4f6WoF+gaB7+KlvTphBcLxDbED/yCZUbKjkhQ98Uz66d8yNcVQ==", "167b4b55-a893-40b0-9f31-cd3cfbe1c547" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "398a846c-2b2c-4b01-90f2-55d342268673",
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 21, 3, 12, 837, DateTimeKind.Utc).AddTicks(6887));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40941ea9-019c-415c-a101-9ccbc93a07d6",
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 21, 3, 12, 837, DateTimeKind.Utc).AddTicks(6781));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54a7eca8-ed42-4444-8522-d5a00310ed62",
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 21, 3, 12, 837, DateTimeKind.Utc).AddTicks(6794));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "668c6a85-f13f-43e9-b898-64d210b1cd45",
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 21, 3, 12, 837, DateTimeKind.Utc).AddTicks(6803));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 21, 3, 12, 837, DateTimeKind.Utc).AddTicks(6805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "800a6ca2-3027-4a0f-ae72-0156405a6a58",
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 21, 3, 12, 837, DateTimeKind.Utc).AddTicks(6798));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 21, 3, 12, 837, DateTimeKind.Utc).AddTicks(6800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b109e70a-6b64-489f-a216-1d407abcf02f",
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 21, 3, 12, 837, DateTimeKind.Utc).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 21, 3, 12, 837, DateTimeKind.Utc).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                column: "DateCreated",
                value: new DateTime(2025, 1, 1, 21, 3, 12, 837, DateTimeKind.Utc).AddTicks(6779));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { "099f8771-9a5a-4b9c-9013-c38612a7c410", "Accurate sleep tracking, but the battery life is shorter than expected.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 21, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1423), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "0a3bedb9-59b5-49bc-bc33-525d0178e49a", "A bit pricey, but I love how it learns my preferences!", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 17, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1434), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "17964d38-4440-404c-bf79-222457f3b26f", "This vacuum cleaner has saved me so much time. Highly recommend!", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 24, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1437), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "2a96dc4e-6f7e-4866-b350-2875c196c943", "Good hub, but it doesn't support some devices I own.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 14, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1440), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "400b3cd7-9b19-4200-ba0c-5a262397505b", "Fun to use and great for parties! The color-changing feature is amazing.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2024, 12, 27, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1401), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "48aa1905-a231-4b2d-8964-69441164cb0c", "This doorbell camera works great! The motion detection is very accurate.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 22, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1429), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "5187a160-59f7-4c7e-9f98-9b0ae6f01266", "Works well for basic needs, but advanced users may want more features.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 16, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1425), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "5f158b38-627e-4fe3-9503-7590c6eb0b14", "The night vision is good, but the motion detection can be too sensitive.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 4, new DateTime(2024, 12, 18, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1415), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "62bf7da8-7dbb-4349-ae63-b88b4c90edfe", "The lights are fantastic, and the app is super intuitive.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2024, 12, 25, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1421), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "62f21bcc-4ee8-4d74-a9c7-71f972ea1b8b", "The hub has some lag when controlling multiple devices.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 2, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1414), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "631ba49f-257f-4f18-9beb-a1b3c3ca1bcc", "Great design, but I wish the touch screen was more responsive.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 4, new DateTime(2024, 12, 10, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1419), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "8ccc5774-e6ad-4f41-a629-bed6d19369f5", "Simple to use and very informative. A must-have for saving energy.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 2, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1445), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "9853d25e-5f84-4dbf-aad6-d20594f4733e", "I saved so much energy with this plug. The real-time monitoring is awesome.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 14, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1407), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "a09a27b3-1575-458a-b7fa-ed46bfb58137", "The robot vacuum works well on carpets and tiles but struggles with edges.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 4, new DateTime(2024, 12, 20, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1405), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "a1fda3a9-2c7a-4fef-b75c-d2f43dd008e6", "This thermostat was a game-changer for our energy bills.", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 7, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1408), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "a608e880-32af-45e4-a8e1-61759d3df94d", "Great for tracking my workouts, but the strap feels a bit cheap.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 20, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1439), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "a956d3a9-e611-4e41-829b-5de4a86df93b", "Easy to install and very efficient for garden watering.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 23, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1428), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "af49a8b2-1602-4387-9694-792464a9ecc3", "The lights are very bright and the app is easy to use.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 4, new DateTime(2024, 12, 12, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1431), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "bb55a811-d631-43dc-b1ad-3cb6e50cd493", "The weather-based feature works like a charm for my garden.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 24, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1411), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "c1df994b-1b15-4b4e-b5ea-a5443c7dc679", "The refrigerator is sleek, but I think it's overpriced for the features.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 17, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1284), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "cd70518b-62e2-493d-a5ec-f3ddb5a4f383", "The sprinkler system works well, but setup was confusing.", "398a846c-2b2c-4b01-90f2-55d342268673", 4, new DateTime(2024, 12, 10, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1443), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "cec1365c-a712-4173-9c56-920bf6009650", "A must-have fitness tracker for anyone serious about health.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 5, new DateTime(2024, 12, 12, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1399), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "e11bfa69-0d6f-404c-b252-2aba83bc97b4", "The screen is impressive, but the cooling performance could be better.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 27, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1435), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "f246cdc2-f781-4efb-b5e6-7c3a5829bf1f", "Perfect for busy people. It cleans thoroughly and docks automatically.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 12, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1417), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "faf40d99-11b4-4e69-bccd-e9dda5aac82c", "I love how easy it is to set up this doorbell camera. The image quality is superb.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 22, 21, 3, 13, 62, DateTimeKind.Utc).AddTicks(1277), "12345678-9abc-def0-1234-56789abcdef0" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "099f8771-9a5a-4b9c-9013-c38612a7c410");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "0a3bedb9-59b5-49bc-bc33-525d0178e49a");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "17964d38-4440-404c-bf79-222457f3b26f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "2a96dc4e-6f7e-4866-b350-2875c196c943");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "400b3cd7-9b19-4200-ba0c-5a262397505b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "48aa1905-a231-4b2d-8964-69441164cb0c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "5187a160-59f7-4c7e-9f98-9b0ae6f01266");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "5f158b38-627e-4fe3-9503-7590c6eb0b14");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "62bf7da8-7dbb-4349-ae63-b88b4c90edfe");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "62f21bcc-4ee8-4d74-a9c7-71f972ea1b8b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "631ba49f-257f-4f18-9beb-a1b3c3ca1bcc");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "8ccc5774-e6ad-4f41-a629-bed6d19369f5");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "9853d25e-5f84-4dbf-aad6-d20594f4733e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "a09a27b3-1575-458a-b7fa-ed46bfb58137");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "a1fda3a9-2c7a-4fef-b75c-d2f43dd008e6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "a608e880-32af-45e4-a8e1-61759d3df94d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "a956d3a9-e611-4e41-829b-5de4a86df93b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "af49a8b2-1602-4387-9694-792464a9ecc3");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "bb55a811-d631-43dc-b1ad-3cb6e50cd493");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "c1df994b-1b15-4b4e-b5ea-a5443c7dc679");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "cd70518b-62e2-493d-a5ec-f3ddb5a4f383");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "cec1365c-a712-4173-9c56-920bf6009650");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "e11bfa69-0d6f-404c-b252-2aba83bc97b4");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f246cdc2-f781-4efb-b5e6-7c3a5829bf1f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "faf40d99-11b4-4e69-bccd-e9dda5aac82c");

            migrationBuilder.DropColumn(
                name: "OrderStatus",
                table: "Orders");

            migrationBuilder.RenameColumn(
                name: "PaymentStatus",
                table: "Orders",
                newName: "Status");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11223344-5566-7788-99aa-bbccddeeff00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "443c19c8-9f36-407b-bd77-aa0f5c1714be", "AQAAAAIAAYagAAAAEP1wHZgrUqj20UIex7x+gpinEaQKsobUg7gVX7hSdocytHMhCxE3/8wZ96JRRqbN0g==", "f1a46110-9a1a-4d0d-9850-b15e550474f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "323940a4-3947-4460-9ace-203935b9625c", "AQAAAAIAAYagAAAAEDGExgbNF6IxPl4nxgkynQVQHZzJv4YeNNc61j33pCNOsoQlnMmB2MV7sTdz+ewOpA==", "c41799af-1a1f-4591-8190-29e5cdda3ca8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e53fa4ed-8516-470c-bc48-590527d68b2b", "AQAAAAIAAYagAAAAEFWMLGGDeBK/tC+L2JXrJJVPAsBvGh5OFVsxYZgxuoSp7C5gZwht/gCMXKGF9vgY3Q==", "7f81be4b-68a9-4786-bbcc-18ec71bf4338" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0e0fcaf4-1f79-4a70-a070-5ca4dd15ad41", "AQAAAAIAAYagAAAAEO2hAYUWlhcGQjW9+HgaoctfSMC//Ao92/e/k5OGb5zbD1xVrsb91f8wT45BK64YqQ==", "0bb0c917-7bfa-472f-8693-ceb1cad40750" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1d34db5-43ba-42ea-b178-d44cd996ca9b", "AQAAAAIAAYagAAAAEDFzYC0MceMHPYRKWPUzl7AG5FclrKB+bOmPopSersXuEzjwUz2PmBK/GuxKHXDCjQ==", "85d75791-2c5b-4613-a670-c090201b1035" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "398a846c-2b2c-4b01-90f2-55d342268673",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 21, 57, 59, 69, DateTimeKind.Utc).AddTicks(8816));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40941ea9-019c-415c-a101-9ccbc93a07d6",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 21, 57, 59, 69, DateTimeKind.Utc).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54a7eca8-ed42-4444-8522-d5a00310ed62",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 21, 57, 59, 69, DateTimeKind.Utc).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "668c6a85-f13f-43e9-b898-64d210b1cd45",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 21, 57, 59, 69, DateTimeKind.Utc).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 21, 57, 59, 69, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "800a6ca2-3027-4a0f-ae72-0156405a6a58",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 21, 57, 59, 69, DateTimeKind.Utc).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 21, 57, 59, 69, DateTimeKind.Utc).AddTicks(8792));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b109e70a-6b64-489f-a216-1d407abcf02f",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 21, 57, 59, 69, DateTimeKind.Utc).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 21, 57, 59, 69, DateTimeKind.Utc).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 21, 57, 59, 69, DateTimeKind.Utc).AddTicks(8767));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { "00b06dc2-faa4-41f7-9668-acc8577b30bd", "The weather-based feature works like a charm for my garden.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 18, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6796), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "04d39568-01d4-4da2-859a-cd5ccb239d17", "The refrigerator is sleek, but I think it's overpriced for the features.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 11, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6764), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "05f0c71b-504f-4499-bf48-2001090c9659", "A must-have fitness tracker for anyone serious about health.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 5, new DateTime(2024, 12, 6, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6769), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "2d37164c-ebe5-4eef-9e84-c58486d61210", "The sprinkler system works well, but setup was confusing.", "398a846c-2b2c-4b01-90f2-55d342268673", 4, new DateTime(2024, 12, 4, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6878), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "300f52d2-f044-4c0c-b174-691ccf380180", "Simple to use and very informative. A must-have for saving energy.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 11, 26, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6882), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "4215b968-3171-4bc4-94a0-efee5ac2e7be", "Works well for basic needs, but advanced users may want more features.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 10, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6833), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "54bf2262-e52f-4711-b26f-e9498636f337", "Easy to install and very efficient for garden watering.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 17, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6837), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "5dc360bf-46d8-45b1-937b-91ae7d762c5e", "The lights are very bright and the app is easy to use.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 4, new DateTime(2024, 12, 6, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6849), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "726f6524-0f1c-48c5-b804-b43e4040fce0", "Great for tracking my workouts, but the strap feels a bit cheap.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 14, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6870), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "7dec038c-67b1-457c-981f-b2b896c6dfa2", "This doorbell camera works great! The motion detection is very accurate.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 16, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6841), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "84cb92f0-ec89-49bb-850b-d3591d7479ab", "I saved so much energy with this plug. The real-time monitoring is awesome.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 8, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6787), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "8e68ac92-c9f9-4007-909f-d0e2596d6a6c", "Accurate sleep tracking, but the battery life is shorter than expected.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 15, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6829), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "9080907d-14c2-4841-b697-e73adc782ca9", "I love how easy it is to set up this doorbell camera. The image quality is superb.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 16, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6749), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "ab517a04-d7bc-4aea-8702-d34b6d8eadb2", "Fun to use and great for parties! The color-changing feature is amazing.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2024, 12, 21, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6775), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "ad9032a9-bfdf-4dd9-ba2c-7d03c3b986cd", "The screen is impressive, but the cooling performance could be better.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 21, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6862), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "b7021282-bf60-4d41-8df1-6d6c30fb056e", "The hub has some lag when controlling multiple devices.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 11, 26, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6802), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "bac15b53-c541-4fa8-9a66-02dce7cca058", "A bit pricey, but I love how it learns my preferences!", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 11, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6858), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "bc815757-77d3-4644-b703-54730ec63750", "This thermostat was a game-changer for our energy bills.", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 1, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6792), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "bde2e996-85bf-49a3-9df5-1b9f82c8dfe4", "Perfect for busy people. It cleans thoroughly and docks automatically.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 6, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6816), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "c0139545-e69f-421a-8fe5-12c5d145cfb2", "Good hub, but it doesn't support some devices I own.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 8, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6874), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "c47aa578-7252-4dc5-aba9-427284f955b8", "The lights are fantastic, and the app is super intuitive.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2024, 12, 19, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6825), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "c81b6219-1afa-462f-9d67-8d69e28c4767", "The robot vacuum works well on carpets and tiles but struggles with edges.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 4, new DateTime(2024, 12, 14, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6783), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "e5d3de76-505b-42a2-84d8-b1a7fcbfebd6", "This vacuum cleaner has saved me so much time. Highly recommend!", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 18, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6866), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "ea0e4368-e9eb-4ba5-8962-248cf9547360", "Great design, but I wish the touch screen was more responsive.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 4, new DateTime(2024, 12, 4, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6820), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "f6953bbb-db92-4c95-9cab-48bd26727268", "The night vision is good, but the motion detection can be too sensitive.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 4, new DateTime(2024, 12, 12, 21, 57, 59, 547, DateTimeKind.Utc).AddTicks(6811), "11223344-5566-7788-99aa-bbccddeeff00" }
                });
        }
    }
}

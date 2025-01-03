
using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedActivitiesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EntityId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EntityType = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activities_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11223344-5566-7788-99aa-bbccddeeff00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d8c012a-fc28-4f9d-8eb3-972909637b69", "AQAAAAIAAYagAAAAEAzPCwnDCaeGCbJhXC1qnr+mQr+XYD4pL9PU2plnPEfnevmMTElRoFsOhcYbAvXxag==", "4bd09930-8a6b-4862-aa66-8c10397df7d0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3d4ba3a-be4d-4fa1-823b-bb88c4070716", "AQAAAAIAAYagAAAAEGjR9+Sgo1DUYuuc+BQu17is9kuXFioksO89/yil3JP7tiAgnX1YKGH1ZmykyWHDrA==", "d251abf3-bb77-40ec-aa13-3007196bf52e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "afbdad64-f7f8-486b-a73d-33a394da6c9e", "AQAAAAIAAYagAAAAEAZgv4bNbNUVRssQql5jDWl4yHrwJtvjVvI8+dQeGCib6hB9QWEE/Z+I9bvM2JjuTg==", "e61daa14-bbf1-4903-94b0-071b8a5ce7b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "72d392e8-27de-4446-b189-dfc56a6b2488", "AQAAAAIAAYagAAAAENDbspeizimma50JowLd/MXvIyP5/YbpN5yGCKM+uAyDUMoi3JuoR2VY84xwqrPuLg==", "57c043db-b860-42dd-92eb-45380c4c051d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c8de4485-e0b7-4ee2-aaea-3e5a9fd364bf", "AQAAAAIAAYagAAAAEIVwfjqrAb4fNprfWzcNs9z/J/bp1DxDNowbnZf55J5/VxJHDDZMdgyHgPxboOW0Og==", "e5d4323c-1743-4430-962e-8cf5c18b4d31" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "398a846c-2b2c-4b01-90f2-55d342268673",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 5, 41, 167, DateTimeKind.Utc).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40941ea9-019c-415c-a101-9ccbc93a07d6",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 5, 41, 167, DateTimeKind.Utc).AddTicks(3705));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54a7eca8-ed42-4444-8522-d5a00310ed62",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 5, 41, 167, DateTimeKind.Utc).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "668c6a85-f13f-43e9-b898-64d210b1cd45",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 5, 41, 167, DateTimeKind.Utc).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 5, 41, 167, DateTimeKind.Utc).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "800a6ca2-3027-4a0f-ae72-0156405a6a58",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 5, 41, 167, DateTimeKind.Utc).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 5, 41, 167, DateTimeKind.Utc).AddTicks(3722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b109e70a-6b64-489f-a216-1d407abcf02f",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 5, 41, 167, DateTimeKind.Utc).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 5, 41, 167, DateTimeKind.Utc).AddTicks(3694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 5, 41, 167, DateTimeKind.Utc).AddTicks(3702));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { "0d1ee6ae-d7b4-4967-836c-6a769e651540", "Fun to use and great for parties! The color-changing feature is amazing.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2024, 12, 29, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1899), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "18d4cdd2-1fd8-4721-9d34-4dadd6dbac47", "The robot vacuum works well on carpets and tiles but struggles with edges.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 4, new DateTime(2024, 12, 22, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1906), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "2d5d4355-1bbd-4649-91b8-73ef4de6107b", "I love how easy it is to set up this doorbell camera. The image quality is superb.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 24, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1883), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "300f90e9-aadb-4673-8f5a-24438a998e7a", "Works well for basic needs, but advanced users may want more features.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 18, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1936), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "35ddf40b-42eb-44a9-82a7-e101f9b84efb", "The refrigerator is sleek, but I think it's overpriced for the features.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 19, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1893), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "38847545-f41d-477b-a9db-4365e6b76c9f", "Good hub, but it doesn't support some devices I own.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 16, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1961), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "38d2dccd-fb2d-47f7-98cf-fa138c4445b6", "The lights are fantastic, and the app is super intuitive.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2024, 12, 27, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1931), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "39077d43-1c63-4e0a-9835-c04d7a286c1e", "This doorbell camera works great! The motion detection is very accurate.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 24, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1941), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "47e19a65-8f84-426c-8baf-fce1933311a5", "The screen is impressive, but the cooling performance could be better.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 29, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1951), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "4a610661-df05-4f94-a2ea-05adf9166fd0", "A bit pricey, but I love how it learns my preferences!", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 19, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1948), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "53896631-e52f-4d0e-b8f5-2d108139edcc", "This thermostat was a game-changer for our energy bills.", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 9, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1911), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "5786d939-5676-423e-ab83-be853f9f5f2c", "The night vision is good, but the motion detection can be too sensitive.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 4, new DateTime(2024, 12, 20, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1920), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "65d1b563-f121-44ca-98cc-5b425605f660", "The lights are very bright and the app is easy to use.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 4, new DateTime(2024, 12, 14, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1944), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "7c0ab0f5-3dfe-4bae-8ea5-54f493b7742e", "Perfect for busy people. It cleans thoroughly and docks automatically.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 14, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1922), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "7e50ee45-482f-4e88-b750-5a2817cf1be5", "Great for tracking my workouts, but the strap feels a bit cheap.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 22, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1959), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "94294921-5cc8-4e0d-aca4-23fb008c4e60", "Easy to install and very efficient for garden watering.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 25, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1938), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "9a2ff4f7-1191-4018-a5b7-f273649bc0e6", "The hub has some lag when controlling multiple devices.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 4, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1917), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "ab0529df-c084-43bf-9247-6e9864c097de", "Simple to use and very informative. A must-have for saving energy.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 4, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1966), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "af656df3-9f44-4d7c-9502-a57d6153bf43", "Accurate sleep tracking, but the battery life is shorter than expected.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 23, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1933), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "b11307c3-44fb-4003-bfba-30833d783f00", "A must-have fitness tracker for anyone serious about health.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 5, new DateTime(2024, 12, 14, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1897), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "bd33941d-bfda-4b40-9706-70edb63368db", "The weather-based feature works like a charm for my garden.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 26, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1914), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "d1f8d21d-98ca-4c71-ac09-9c63190d5be7", "Great design, but I wish the touch screen was more responsive.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 4, new DateTime(2024, 12, 12, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1925), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "dedbb9ef-a8b4-47be-9149-864d78d9eb4a", "I saved so much energy with this plug. The real-time monitoring is awesome.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 16, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1909), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "e2c907a5-da31-4e70-a322-1dd55432412c", "This vacuum cleaner has saved me so much time. Highly recommend!", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 26, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1956), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "f1347abf-8848-4384-af7d-3ac9e452eb62", "The sprinkler system works well, but setup was confusing.", "398a846c-2b2c-4b01-90f2-55d342268673", 4, new DateTime(2024, 12, 12, 0, 5, 41, 459, DateTimeKind.Utc).AddTicks(1964), "fedcba98-7654-3210-fedc-ba9876543210" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activities_UserId",
                table: "Activities",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "0d1ee6ae-d7b4-4967-836c-6a769e651540");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "18d4cdd2-1fd8-4721-9d34-4dadd6dbac47");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "2d5d4355-1bbd-4649-91b8-73ef4de6107b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "300f90e9-aadb-4673-8f5a-24438a998e7a");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "35ddf40b-42eb-44a9-82a7-e101f9b84efb");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "38847545-f41d-477b-a9db-4365e6b76c9f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "38d2dccd-fb2d-47f7-98cf-fa138c4445b6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "39077d43-1c63-4e0a-9835-c04d7a286c1e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "47e19a65-8f84-426c-8baf-fce1933311a5");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "4a610661-df05-4f94-a2ea-05adf9166fd0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "53896631-e52f-4d0e-b8f5-2d108139edcc");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "5786d939-5676-423e-ab83-be853f9f5f2c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "65d1b563-f121-44ca-98cc-5b425605f660");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "7c0ab0f5-3dfe-4bae-8ea5-54f493b7742e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "7e50ee45-482f-4e88-b750-5a2817cf1be5");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "94294921-5cc8-4e0d-aca4-23fb008c4e60");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "9a2ff4f7-1191-4018-a5b7-f273649bc0e6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ab0529df-c084-43bf-9247-6e9864c097de");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "af656df3-9f44-4d7c-9502-a57d6153bf43");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b11307c3-44fb-4003-bfba-30833d783f00");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "bd33941d-bfda-4b40-9706-70edb63368db");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "d1f8d21d-98ca-4c71-ac09-9c63190d5be7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "dedbb9ef-a8b4-47be-9149-864d78d9eb4a");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "e2c907a5-da31-4e70-a322-1dd55432412c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f1347abf-8848-4384-af7d-3ac9e452eb62");

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
    }
}

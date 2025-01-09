using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedTechinicansTableAndTechniciansProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "00c37598-fdbf-465f-b5bc-3864846d5e57");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "1688ffe5-99e0-43ca-a891-802589ab444a");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "184f8b14-c08a-4391-8e13-889b9b53929a");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "1e1cd348-5fcc-4ae6-9063-18d2159886c2");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "20e27c83-3a3b-43a5-9289-8b65b38fe708");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "23e41b37-e5d2-47de-985b-9fd82d0282d6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "24890be7-0d09-4f48-84ec-42e00ad440b0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "2ae6d013-2fe4-4acd-83c3-2c2cddf92cdc");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "2e62c9d4-6793-41c1-b5d1-f98b5ebc791d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "3988be9e-ef31-4cea-9973-fa7256767aca");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "43019502-5880-4f62-9460-e71c07a211bd");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "44306025-04df-43da-828f-eb6114e858c4");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "6769cba7-2b20-45f5-977b-11b92af48c6d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "7eaf132e-60e9-44ab-9b42-b221f9257f1b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "bfd8bafc-0eee-4222-9463-126735337714");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "c0b628b8-4747-4631-be25-ee4f5d59958e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "c75da321-7203-4967-9bc7-297cae1380a6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "c85d3445-4662-4907-86e9-5d206be3cebf");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "c896daca-40b1-4268-a9eb-f76aae11e181");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "d0820953-9257-48e8-999e-845c3289a98c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "d9a7a73b-3f70-4e2f-a05f-463447223fe4");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f05c55fc-d304-4afd-a470-31af5c55d23f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f0dc505f-8c1f-402c-9b07-bd0e280af298");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f7665340-d5b5-4863-bb55-75e8bff9318b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f9274a2f-a5bf-41d9-8d87-b194bb39967b");

            migrationBuilder.CreateTable(
                name: "Technicians",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Technicians", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Technicians_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TechniciansProducts",
                columns: table => new
                {
                    TechnicianId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TechniciansProducts", x => new { x.ProductId, x.TechnicianId });
                    table.ForeignKey(
                        name: "FK_TechniciansProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TechniciansProducts_Technicians_TechnicianId",
                        column: x => x.TechnicianId,
                        principalTable: "Technicians",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Technicians_UserId",
                table: "Technicians",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_TechniciansProducts_TechnicianId",
                table: "TechniciansProducts",
                column: "TechnicianId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TechniciansProducts");

            migrationBuilder.DropTable(
                name: "Technicians");

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11223344-5566-7788-99aa-bbccddeeff00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c3726a87-290c-4265-a258-5c1648d213fd", "AQAAAAIAAYagAAAAEBQef0z4VWYJMDEKFndexhm2Fd4wO8QaB3kXKFfkY5iRNZiYXgWXnO1FM/7sGS/6Sw==", "0aad7da3-eabf-4d3b-a2a5-36a74d813a30" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "34cde669-c519-43f6-9878-81304dffaf2c", "AQAAAAIAAYagAAAAEMUZNp0SB0CPe827PeFFyBIf2MoPwqRo+rgNdQnCqttigVHOQmc4O5R+OJ2R1gpvcQ==", "0bc50798-a205-4566-a9d2-aed622300a28" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73e8042f-592a-44f4-90b0-c8a9bcfab89a", "AQAAAAIAAYagAAAAECWvEYW2sTeoxrKpMHkA6njuBacUYEHaAYcNWrG1LmLmK6/esIJJ5HMQFsTGOey9vQ==", "de351baa-1010-4c3c-824f-6a0537200d4b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f64f96ea-ea1c-44d1-ac23-34b1fb96d7b8", "AQAAAAIAAYagAAAAEMz/BZccXWf/K2fZ9hUXY7DmRKzWeJpmkPKhw8aoGrFZ2EIyeLnFfpQ0T/7v6SW5ew==", "528a8171-134d-4f5b-9c45-31dc46671971" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74f4e23b-a2e4-4abb-ac83-9fcfd4fc6ffa", "AQAAAAIAAYagAAAAEBA2MFqpCYN6NUaRDnXTgTm4zfqhVBAKVw1FSWPI+zsqEKnBp2VZ78wJ8fGovtaPfA==", "8eef63e0-df6a-41d4-9d97-f8a662178ad9" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "398a846c-2b2c-4b01-90f2-55d342268673",
                column: "DateCreated",
                value: new DateTime(2025, 1, 7, 0, 9, 36, 789, DateTimeKind.Utc).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40941ea9-019c-415c-a101-9ccbc93a07d6",
                column: "DateCreated",
                value: new DateTime(2025, 1, 7, 0, 9, 36, 789, DateTimeKind.Utc).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54a7eca8-ed42-4444-8522-d5a00310ed62",
                column: "DateCreated",
                value: new DateTime(2025, 1, 7, 0, 9, 36, 789, DateTimeKind.Utc).AddTicks(8579));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "668c6a85-f13f-43e9-b898-64d210b1cd45",
                column: "DateCreated",
                value: new DateTime(2025, 1, 7, 0, 9, 36, 789, DateTimeKind.Utc).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                column: "DateCreated",
                value: new DateTime(2025, 1, 7, 0, 9, 36, 789, DateTimeKind.Utc).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "800a6ca2-3027-4a0f-ae72-0156405a6a58",
                column: "DateCreated",
                value: new DateTime(2025, 1, 7, 0, 9, 36, 789, DateTimeKind.Utc).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
                column: "DateCreated",
                value: new DateTime(2025, 1, 7, 0, 9, 36, 789, DateTimeKind.Utc).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b109e70a-6b64-489f-a216-1d407abcf02f",
                column: "DateCreated",
                value: new DateTime(2025, 1, 7, 0, 9, 36, 789, DateTimeKind.Utc).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                column: "DateCreated",
                value: new DateTime(2025, 1, 7, 0, 9, 36, 789, DateTimeKind.Utc).AddTicks(8548));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                column: "DateCreated",
                value: new DateTime(2025, 1, 7, 0, 9, 36, 789, DateTimeKind.Utc).AddTicks(8571));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { "00c37598-fdbf-465f-b5bc-3864846d5e57", "The lights are fantastic, and the app is super intuitive.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2024, 12, 31, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4189), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "1688ffe5-99e0-43ca-a891-802589ab444a", "Fun to use and great for parties! The color-changing feature is amazing.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2025, 1, 2, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(3146), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "184f8b14-c08a-4391-8e13-889b9b53929a", "This thermostat was a game-changer for our energy bills.", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 13, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(3160), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "1e1cd348-5fcc-4ae6-9063-18d2159886c2", "Works well for basic needs, but advanced users may want more features.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 22, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4202), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "20e27c83-3a3b-43a5-9289-8b65b38fe708", "Good hub, but it doesn't support some devices I own.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 20, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4231), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "23e41b37-e5d2-47de-985b-9fd82d0282d6", "The night vision is good, but the motion detection can be too sensitive.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 4, new DateTime(2024, 12, 24, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4180), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "24890be7-0d09-4f48-84ec-42e00ad440b0", "I love how easy it is to set up this doorbell camera. The image quality is superb.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 28, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(3130), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "2ae6d013-2fe4-4acd-83c3-2c2cddf92cdc", "A must-have fitness tracker for anyone serious about health.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 5, new DateTime(2024, 12, 18, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(3142), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "2e62c9d4-6793-41c1-b5d1-f98b5ebc791d", "Accurate sleep tracking, but the battery life is shorter than expected.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 27, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4198), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "3988be9e-ef31-4cea-9973-fa7256767aca", "I saved so much energy with this plug. The real-time monitoring is awesome.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 20, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(3157), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "43019502-5880-4f62-9460-e71c07a211bd", "Perfect for busy people. It cleans thoroughly and docks automatically.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 18, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4183), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "44306025-04df-43da-828f-eb6114e858c4", "The robot vacuum works well on carpets and tiles but struggles with edges.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 4, new DateTime(2024, 12, 26, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(3149), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "6769cba7-2b20-45f5-977b-11b92af48c6d", "Simple to use and very informative. A must-have for saving energy.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 8, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4237), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "7eaf132e-60e9-44ab-9b42-b221f9257f1b", "The screen is impressive, but the cooling performance could be better.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2025, 1, 2, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4218), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "bfd8bafc-0eee-4222-9463-126735337714", "The refrigerator is sleek, but I think it's overpriced for the features.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 23, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(3139), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "c0b628b8-4747-4631-be25-ee4f5d59958e", "This doorbell camera works great! The motion detection is very accurate.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 28, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4207), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "c75da321-7203-4967-9bc7-297cae1380a6", "A bit pricey, but I love how it learns my preferences!", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 23, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4215), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "c85d3445-4662-4907-86e9-5d206be3cebf", "Great for tracking my workouts, but the strap feels a bit cheap.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 26, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4228), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "c896daca-40b1-4268-a9eb-f76aae11e181", "Easy to install and very efficient for garden watering.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 29, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4205), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "d0820953-9257-48e8-999e-845c3289a98c", "This vacuum cleaner has saved me so much time. Highly recommend!", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 30, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4221), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "d9a7a73b-3f70-4e2f-a05f-463447223fe4", "The hub has some lag when controlling multiple devices.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 8, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4174), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "f05c55fc-d304-4afd-a470-31af5c55d23f", "The weather-based feature works like a charm for my garden.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 30, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(3162), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "f0dc505f-8c1f-402c-9b07-bd0e280af298", "Great design, but I wish the touch screen was more responsive.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 4, new DateTime(2024, 12, 16, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4186), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "f7665340-d5b5-4863-bb55-75e8bff9318b", "The lights are very bright and the app is easy to use.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 4, new DateTime(2024, 12, 18, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4209), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "f9274a2f-a5bf-41d9-8d87-b194bb39967b", "The sprinkler system works well, but setup was confusing.", "398a846c-2b2c-4b01-90f2-55d342268673", 4, new DateTime(2024, 12, 16, 0, 9, 37, 99, DateTimeKind.Utc).AddTicks(4233), "fedcba98-7654-3210-fedc-ba9876543210" }
                });
        }
    }
}

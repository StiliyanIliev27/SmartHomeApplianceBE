using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedLongAndLatToTechnicianEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "15450653-fa12-48c5-ac4c-69414bae3531");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "191ff85d-315c-4d04-a50d-832f4bfb7f6d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "302fcf7e-70b3-47d4-94a5-c5b4abc4fdbd");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "35072193-9446-44b4-9d30-fa51f44bf01f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "472f1c4f-5abb-4264-9c0f-7c2fe5537905");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "58702f62-0c9a-45f6-9c37-999a40fdcfc7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "616487a2-9af2-4938-94e0-54fe90939f4e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "6228d983-6d29-4475-b0e2-636b1187be8d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "701cc918-9bb0-4da0-87c3-c7b3a0f7e29b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "7072ab6b-c731-46c8-9b41-3b9618f9de9c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "76ff430d-22cf-48f5-bab6-fcee2d7369b9");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "7ebf8c65-f15b-4a54-87a2-b94934d17809");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "7fde037f-8efd-4bbe-a5f1-1574011e3631");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "91e5b600-abb4-4692-83f7-e77b5795ce92");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "935b504a-f0de-4a70-a07b-2781821f1346");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "a2c4e5ba-be40-4456-9db5-9be19793b1e9");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "a308f649-631b-4817-a4a6-9e6bbe713564");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b205f24a-bb12-45bf-ba76-43b5f8452274");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b39c6133-e640-4c22-bfd0-93da6cfb5783");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "bb821401-31f6-4d44-be28-a632f0acc234");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ddd702dc-8d4e-4312-8100-7fbde2230806");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "e0ee5999-d228-425c-bd26-0e7cd9033617");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "e6fc4585-40d5-4cf9-8e82-3f77b4dc22b0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f2fe3e14-e70a-4727-a43b-ddcfaa80aa82");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f3622ea8-2ede-4314-a488-73ecb1edd456");

            migrationBuilder.AddColumn<string>(
                name: "Lat",
                table: "Technicians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Long",
                table: "Technicians",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11223344-5566-7788-99aa-bbccddeeff00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b0bf1654-e01c-4362-9f61-f23e8784c6b7", "AQAAAAIAAYagAAAAEOFF1t37UdHe/XY+tmbI109lmIVTATLvUrz1S62ORle4/0uer8ssCrx+ixMHwN5kdQ==", "abe5d04c-e677-44b2-bea6-f0abb0d45f19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46eb8f6f-1357-4861-a8c6-4557f65fd028", "AQAAAAIAAYagAAAAEET3IvOE59YxBkXeFqM/scrK/GoDovYayotQtSXywAcG+9xyywA+yF7NQv611YsX7g==", "820965d5-ccab-482b-bb46-543d6a7dad0d" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87b3a84c-b6cd-4bc2-b020-9df06af1a420", "AQAAAAIAAYagAAAAELtWCJc4St85icrYY2fmAaKMCDwH/Cev+PEwK3TgHPrhxVCXW/C/5VjHq53I25hVWw==", "3a85148e-ac8d-40e1-a77b-221d020f6dcb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8c619f49-1f74-480b-ad98-081c4656b3e3", "AQAAAAIAAYagAAAAEK45Tscy4CzbVglEVLMZV8l9tJxpWW2S2AEy5Zz+x23xpuyRbrH3IVtHuN3TXcuYkg==", "cedf1e8b-2ef2-4203-bffa-63ee283ccc6f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95e11481-f0f5-436e-a8af-6ad3efdbadf6", "AQAAAAIAAYagAAAAEORABsabRhQt1+portJ3xVtQu2v94/68BGPo+JrnUazOBpYXcbOdb0TH6kYWsWjaKA==", "9edbbb16-3a46-44c4-bb62-1ea33dc80331" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "398a846c-2b2c-4b01-90f2-55d342268673",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 23, 54, 8, 966, DateTimeKind.Utc).AddTicks(8485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40941ea9-019c-415c-a101-9ccbc93a07d6",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 23, 54, 8, 966, DateTimeKind.Utc).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54a7eca8-ed42-4444-8522-d5a00310ed62",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 23, 54, 8, 966, DateTimeKind.Utc).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "668c6a85-f13f-43e9-b898-64d210b1cd45",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 23, 54, 8, 966, DateTimeKind.Utc).AddTicks(8477));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 23, 54, 8, 966, DateTimeKind.Utc).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "800a6ca2-3027-4a0f-ae72-0156405a6a58",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 23, 54, 8, 966, DateTimeKind.Utc).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 23, 54, 8, 966, DateTimeKind.Utc).AddTicks(8474));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b109e70a-6b64-489f-a216-1d407abcf02f",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 23, 54, 8, 966, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 23, 54, 8, 966, DateTimeKind.Utc).AddTicks(8447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 23, 54, 8, 966, DateTimeKind.Utc).AddTicks(8452));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { "05263953-b077-48a4-95b3-ccc6cad90813", "This doorbell camera works great! The motion detection is very accurate.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 30, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8990), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "06040cf2-f302-46d5-950b-e27b54f20685", "Perfect for busy people. It cleans thoroughly and docks automatically.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 20, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8980), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "36ee96d7-aa03-4049-b3b4-4d6318b52fae", "I saved so much energy with this plug. The real-time monitoring is awesome.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 22, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8969), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "3c539dc9-f1aa-437a-91f0-080b387f52db", "The lights are fantastic, and the app is super intuitive.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2025, 1, 2, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8983), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "47ed1c53-cf3c-4c68-ad4d-341642112d4d", "The refrigerator is sleek, but I think it's overpriced for the features.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 25, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8959), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "5bbde54a-5114-4b7c-ad68-fa5fc646f791", "The hub has some lag when controlling multiple devices.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 10, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8975), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "5c1604f6-9931-48fe-bab1-3eedda2c7512", "The robot vacuum works well on carpets and tiles but struggles with edges.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 4, new DateTime(2024, 12, 28, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8967), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "66563481-589a-44a9-8bb7-9147fe840cdb", "Works well for basic needs, but advanced users may want more features.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 24, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8987), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "69abd55f-98e5-4f6d-b9df-1755282fa096", "The screen is impressive, but the cooling performance could be better.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2025, 1, 4, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(9035), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "7367ed5c-5845-4e75-a998-a43cd25d405d", "This thermostat was a game-changer for our energy bills.", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 15, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8971), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "7ef40887-f143-4f2b-a22c-360a3256865e", "Simple to use and very informative. A must-have for saving energy.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 10, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(9044), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "8c5d34b0-2251-42b9-9792-c92b542b4a44", "Great design, but I wish the touch screen was more responsive.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 4, new DateTime(2024, 12, 18, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8981), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "90a7e90b-8ddb-4ee6-bfc8-beae1fb5e205", "The weather-based feature works like a charm for my garden.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2025, 1, 1, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8972), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "90aabb0c-18e4-4847-be83-f3de46aaa40d", "Good hub, but it doesn't support some devices I own.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 22, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(9040), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "a4a732ab-3a5d-4f1a-a089-41fc8d41a0ea", "The lights are very bright and the app is easy to use.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 4, new DateTime(2024, 12, 20, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8992), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "a51d7a39-16d6-40ea-8e8c-2b0e8c503a14", "The night vision is good, but the motion detection can be too sensitive.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 4, new DateTime(2024, 12, 26, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8976), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "a7b07590-95f0-41ca-a2ea-d93470e6e0c7", "A must-have fitness tracker for anyone serious about health.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 5, new DateTime(2024, 12, 20, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8963), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "c377ee8a-ba7a-4df9-b39f-1b5fac86f114", "Easy to install and very efficient for garden watering.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 31, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8988), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "c4757b16-9591-4ce8-a600-480c52329edd", "Fun to use and great for parties! The color-changing feature is amazing.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2025, 1, 4, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8965), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "c7ce0e5c-395f-4b26-881d-71b1a0cafb8e", "Great for tracking my workouts, but the strap feels a bit cheap.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 28, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(9039), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "d919dbdf-1f82-4a49-8278-1379f12f0772", "This vacuum cleaner has saved me so much time. Highly recommend!", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2025, 1, 1, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(9037), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "dc3e4950-b090-4b98-85b1-fd2b64e03702", "I love how easy it is to set up this doorbell camera. The image quality is superb.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 30, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8951), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "e9b91078-8618-4d2a-a7b2-189d81c83225", "Accurate sleep tracking, but the battery life is shorter than expected.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 29, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(8985), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "f5ea57b0-4987-4252-bc03-c26c9a431717", "The sprinkler system works well, but setup was confusing.", "398a846c-2b2c-4b01-90f2-55d342268673", 4, new DateTime(2024, 12, 18, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(9042), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "f6481017-9bb9-4e9e-95d7-d814e625e86a", "A bit pricey, but I love how it learns my preferences!", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 25, 23, 54, 9, 201, DateTimeKind.Utc).AddTicks(9033), "11223344-5566-7788-99aa-bbccddeeff00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "05263953-b077-48a4-95b3-ccc6cad90813");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "06040cf2-f302-46d5-950b-e27b54f20685");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "36ee96d7-aa03-4049-b3b4-4d6318b52fae");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "3c539dc9-f1aa-437a-91f0-080b387f52db");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "47ed1c53-cf3c-4c68-ad4d-341642112d4d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "5bbde54a-5114-4b7c-ad68-fa5fc646f791");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "5c1604f6-9931-48fe-bab1-3eedda2c7512");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "66563481-589a-44a9-8bb7-9147fe840cdb");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "69abd55f-98e5-4f6d-b9df-1755282fa096");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "7367ed5c-5845-4e75-a998-a43cd25d405d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "7ef40887-f143-4f2b-a22c-360a3256865e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "8c5d34b0-2251-42b9-9792-c92b542b4a44");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "90a7e90b-8ddb-4ee6-bfc8-beae1fb5e205");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "90aabb0c-18e4-4847-be83-f3de46aaa40d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "a4a732ab-3a5d-4f1a-a089-41fc8d41a0ea");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "a51d7a39-16d6-40ea-8e8c-2b0e8c503a14");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "a7b07590-95f0-41ca-a2ea-d93470e6e0c7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "c377ee8a-ba7a-4df9-b39f-1b5fac86f114");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "c4757b16-9591-4ce8-a600-480c52329edd");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "c7ce0e5c-395f-4b26-881d-71b1a0cafb8e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "d919dbdf-1f82-4a49-8278-1379f12f0772");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "dc3e4950-b090-4b98-85b1-fd2b64e03702");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "e9b91078-8618-4d2a-a7b2-189d81c83225");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f5ea57b0-4987-4252-bc03-c26c9a431717");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f6481017-9bb9-4e9e-95d7-d814e625e86a");

            migrationBuilder.DropColumn(
                name: "Lat",
                table: "Technicians");

            migrationBuilder.DropColumn(
                name: "Long",
                table: "Technicians");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11223344-5566-7788-99aa-bbccddeeff00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "577bf531-35ca-4316-9ef9-086c389d44dd", "AQAAAAIAAYagAAAAEPVb156qnW8ZTXptN1PvClJ+iIAtmWUaLF0VSmqYxOcL1raZbcNB6IEsdAy1Oy4Szw==", "b5009512-2418-4865-a7b6-36fbde674f19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf4a15b7-f4d3-4981-9b01-61f1d4da89a8", "AQAAAAIAAYagAAAAEMi4HJDU1YjGb0ueRlCQoJOeEJ9rDdH55al7tb/0PehGHfF+Mqc4tpPt1B/TlrGUUg==", "0c145999-9ec1-4170-9184-9bd495dcb68a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c5adec8-f97e-4d50-a053-6c405cfba796", "AQAAAAIAAYagAAAAEBf+EWaIoso8XlNf1nWgtOTjQS4176ABdCnAujYAmErHXveBO8YFhqXW1EmMOs7Hqg==", "7ef7f3ce-368d-4ec6-abe1-2ca7aa161985" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "914bddd5-2263-4398-9d75-51780d47a219", "AQAAAAIAAYagAAAAEGs80KYgr2GOCjwFNWOcxHF4IiT6UHXxt3DNLAQU/VzmSI5QJXhfIDtVKcIa7etEow==", "194dd5d6-2fd5-4910-8bfc-1248ca97e071" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44b50b11-fbcd-4b29-8ee8-40021394b0b9", "AQAAAAIAAYagAAAAEBFXgZ+eK5ceDI8r4Jie9XGzaKY7Q3eDs3ocxIDOcJQrHDNs+D8AHnDZ4sHdGi7R5g==", "a6d48759-0962-4f06-bdad-b36f21eb7825" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "398a846c-2b2c-4b01-90f2-55d342268673",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 17, 6, 41, 864, DateTimeKind.Utc).AddTicks(5902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40941ea9-019c-415c-a101-9ccbc93a07d6",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 17, 6, 41, 864, DateTimeKind.Utc).AddTicks(5762));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54a7eca8-ed42-4444-8522-d5a00310ed62",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 17, 6, 41, 864, DateTimeKind.Utc).AddTicks(5766));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "668c6a85-f13f-43e9-b898-64d210b1cd45",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 17, 6, 41, 864, DateTimeKind.Utc).AddTicks(5779));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 17, 6, 41, 864, DateTimeKind.Utc).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "800a6ca2-3027-4a0f-ae72-0156405a6a58",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 17, 6, 41, 864, DateTimeKind.Utc).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 17, 6, 41, 864, DateTimeKind.Utc).AddTicks(5775));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b109e70a-6b64-489f-a216-1d407abcf02f",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 17, 6, 41, 864, DateTimeKind.Utc).AddTicks(5791));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 17, 6, 41, 864, DateTimeKind.Utc).AddTicks(5745));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                column: "DateCreated",
                value: new DateTime(2025, 1, 9, 17, 6, 41, 864, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { "15450653-fa12-48c5-ac4c-69414bae3531", "This vacuum cleaner has saved me so much time. Highly recommend!", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2025, 1, 1, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9501), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "191ff85d-315c-4d04-a50d-832f4bfb7f6d", "The hub has some lag when controlling multiple devices.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 10, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9473), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "302fcf7e-70b3-47d4-94a5-c5b4abc4fdbd", "The night vision is good, but the motion detection can be too sensitive.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 4, new DateTime(2024, 12, 26, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9477), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "35072193-9446-44b4-9d30-fa51f44bf01f", "Simple to use and very informative. A must-have for saving energy.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 10, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9508), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "472f1c4f-5abb-4264-9c0f-7c2fe5537905", "The lights are fantastic, and the app is super intuitive.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2025, 1, 2, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9483), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "58702f62-0c9a-45f6-9c37-999a40fdcfc7", "Accurate sleep tracking, but the battery life is shorter than expected.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 29, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9484), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "616487a2-9af2-4938-94e0-54fe90939f4e", "A bit pricey, but I love how it learns my preferences!", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 25, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9497), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "6228d983-6d29-4475-b0e2-636b1187be8d", "This thermostat was a game-changer for our energy bills.", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 15, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9468), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "701cc918-9bb0-4da0-87c3-c7b3a0f7e29b", "The screen is impressive, but the cooling performance could be better.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2025, 1, 4, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9499), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "7072ab6b-c731-46c8-9b41-3b9618f9de9c", "The lights are very bright and the app is easy to use.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 4, new DateTime(2024, 12, 20, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9493), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "76ff430d-22cf-48f5-bab6-fcee2d7369b9", "Good hub, but it doesn't support some devices I own.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 22, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9505), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "7ebf8c65-f15b-4a54-87a2-b94934d17809", "Easy to install and very efficient for garden watering.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 31, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9488), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "7fde037f-8efd-4bbe-a5f1-1574011e3631", "Great for tracking my workouts, but the strap feels a bit cheap.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 28, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9503), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "91e5b600-abb4-4692-83f7-e77b5795ce92", "Works well for basic needs, but advanced users may want more features.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 24, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9486), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "935b504a-f0de-4a70-a07b-2781821f1346", "Perfect for busy people. It cleans thoroughly and docks automatically.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 20, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9479), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "a2c4e5ba-be40-4456-9db5-9be19793b1e9", "The sprinkler system works well, but setup was confusing.", "398a846c-2b2c-4b01-90f2-55d342268673", 4, new DateTime(2024, 12, 18, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9507), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "a308f649-631b-4817-a4a6-9e6bbe713564", "The weather-based feature works like a charm for my garden.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2025, 1, 1, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9470), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "b205f24a-bb12-45bf-ba76-43b5f8452274", "I saved so much energy with this plug. The real-time monitoring is awesome.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 22, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9466), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "b39c6133-e640-4c22-bfd0-93da6cfb5783", "This doorbell camera works great! The motion detection is very accurate.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 30, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9490), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "bb821401-31f6-4d44-be28-a632f0acc234", "Great design, but I wish the touch screen was more responsive.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 4, new DateTime(2024, 12, 18, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9481), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "ddd702dc-8d4e-4312-8100-7fbde2230806", "The robot vacuum works well on carpets and tiles but struggles with edges.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 4, new DateTime(2024, 12, 28, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9464), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "e0ee5999-d228-425c-bd26-0e7cd9033617", "The refrigerator is sleek, but I think it's overpriced for the features.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 25, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9457), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "e6fc4585-40d5-4cf9-8e82-3f77b4dc22b0", "I love how easy it is to set up this doorbell camera. The image quality is superb.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 30, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9447), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "f2fe3e14-e70a-4727-a43b-ddcfaa80aa82", "Fun to use and great for parties! The color-changing feature is amazing.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2025, 1, 4, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9461), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "f3622ea8-2ede-4314-a488-73ecb1edd456", "A must-have fitness tracker for anyone serious about health.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 5, new DateTime(2024, 12, 20, 17, 6, 42, 178, DateTimeKind.Utc).AddTicks(9460), "12345678-9abc-def0-1234-56789abcdef0" }
                });
        }
    }
}

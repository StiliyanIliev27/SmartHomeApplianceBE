using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ActivityIdUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "17aa6c5d-201d-42d5-951f-26c2ecb6cb79", "AQAAAAIAAYagAAAAEPi+YxnCN1HGlPqSPF3BZ+auWxeLa+mZvf5EdmJFrlN+qmKTaz2UNebW0ia+0sIGvA==", "1abcd013-08ee-41b7-ba7c-a3e5bdceecd4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbd7a6d4-cfd7-45fb-a65a-c49b5e413de8", "AQAAAAIAAYagAAAAEJdxiqAnqmzSYuN2FFdxWpof4MOXyJck81+bmgCORLhnHWZHLVSrJGj/9DGKEFIgqA==", "f0645ae9-b8e1-43db-82f6-2be84059a087" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7bb3624-62e7-482f-8e14-11c7dad4acbb", "AQAAAAIAAYagAAAAEPQcyubYxlGg8PjGXJf4GGbUXX7okoJRPQ5pQNT9eWBEe7355JIQHrimAVko9OqOfg==", "cdd31cc7-04a7-487e-9660-ed78c3ce027b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6ad1b052-2c5e-4b47-9b37-60b367c144e1", "AQAAAAIAAYagAAAAED41Sfs4O3vhPbn0wcVbuGxzw+R06uNxrGAXQ7aq+HDmWLEHclSYXofAQSKG05lujA==", "09624806-a064-4575-a653-17c6c4ea7291" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0c49c76-691a-4c22-9c74-021c3600cbef", "AQAAAAIAAYagAAAAEBub90frelN7ESJVmArUFoA0t9HKLE6soJQswQLccXPcxYoGy27Q6fphzaY7gim9DQ==", "9ca34f7e-cc55-4595-9806-c52467d8191c" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "398a846c-2b2c-4b01-90f2-55d342268673",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 24, 36, 294, DateTimeKind.Utc).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40941ea9-019c-415c-a101-9ccbc93a07d6",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 24, 36, 294, DateTimeKind.Utc).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54a7eca8-ed42-4444-8522-d5a00310ed62",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 24, 36, 294, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "668c6a85-f13f-43e9-b898-64d210b1cd45",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 24, 36, 294, DateTimeKind.Utc).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 24, 36, 294, DateTimeKind.Utc).AddTicks(8849));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "800a6ca2-3027-4a0f-ae72-0156405a6a58",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 24, 36, 294, DateTimeKind.Utc).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 24, 36, 294, DateTimeKind.Utc).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b109e70a-6b64-489f-a216-1d407abcf02f",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 24, 36, 294, DateTimeKind.Utc).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 24, 36, 294, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 0, 24, 36, 294, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { "0aa2f487-11a3-4b8f-9a78-98398ac5ed38", "I saved so much energy with this plug. The real-time monitoring is awesome.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 16, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5594), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "0bb00d68-7025-4088-92b4-b291a6f517de", "The weather-based feature works like a charm for my garden.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 26, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5597), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "0ee1446b-61cc-4fda-b6b6-39c44dc13383", "This vacuum cleaner has saved me so much time. Highly recommend!", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 26, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5627), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "27e34283-9c2c-4242-9406-2aab6c6c7de3", "I love how easy it is to set up this doorbell camera. The image quality is superb.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 24, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5460), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "44651b28-7943-4a34-ac30-98f8004c5ed5", "The hub has some lag when controlling multiple devices.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 4, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5600), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "4792492e-8f0a-4f48-a231-262cecbbe67b", "This thermostat was a game-changer for our energy bills.", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 9, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5595), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "57c751e8-5143-477f-91be-319009751faa", "The refrigerator is sleek, but I think it's overpriced for the features.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 19, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5474), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "5e3ae4cf-7975-40fc-a855-3f6592a0cfed", "Simple to use and very informative. A must-have for saving energy.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 4, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5634), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "655c0623-f392-4df8-ada9-30757473e72c", "This doorbell camera works great! The motion detection is very accurate.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 24, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5617), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "67d27aff-499d-43f7-bb81-331f05e4c34c", "The sprinkler system works well, but setup was confusing.", "398a846c-2b2c-4b01-90f2-55d342268673", 4, new DateTime(2024, 12, 12, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5632), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "6f4064c6-bbe9-4352-a67d-96df0112e0a4", "Easy to install and very efficient for garden watering.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 25, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5615), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "6fe059ac-0df7-4ab8-92d7-bc4313551fd1", "A must-have fitness tracker for anyone serious about health.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 5, new DateTime(2024, 12, 14, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5584), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "849b74e6-5bb8-440a-bc0d-ed17206ff5e9", "The robot vacuum works well on carpets and tiles but struggles with edges.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 4, new DateTime(2024, 12, 22, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5591), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "859e6795-f7c8-45fe-b927-a989c1738448", "Fun to use and great for parties! The color-changing feature is amazing.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2024, 12, 29, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5589), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "8bbac066-b153-4ca7-8abd-acd94bfac3d3", "Great for tracking my workouts, but the strap feels a bit cheap.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 22, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5629), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "9733ef2f-280c-4eeb-9e52-4a5ea2ed6ca4", "Good hub, but it doesn't support some devices I own.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 16, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5630), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "aae0d2f7-eb79-4024-ab6c-dc4389df99e2", "The lights are fantastic, and the app is super intuitive.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2024, 12, 27, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5609), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "b84caafd-54bd-4ac8-a19e-d49924ecf1f7", "Accurate sleep tracking, but the battery life is shorter than expected.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 23, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5611), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "b8ef2a3f-89c8-4ac6-979c-b8535bf7d7bd", "Perfect for busy people. It cleans thoroughly and docks automatically.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 14, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5604), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "cdfb3c98-d34d-4f70-ac59-10632030647c", "The night vision is good, but the motion detection can be too sensitive.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 4, new DateTime(2024, 12, 20, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5602), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "cf2c16c7-c53c-42d0-a1b9-4e7f8e0fdb32", "Works well for basic needs, but advanced users may want more features.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 18, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5613), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "d451e862-24b7-4e4d-8741-e97437c2549b", "Great design, but I wish the touch screen was more responsive.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 4, new DateTime(2024, 12, 12, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5607), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "d781bb10-03ca-4d89-ad8e-24241b207231", "The lights are very bright and the app is easy to use.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 4, new DateTime(2024, 12, 14, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5618), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "d78d5faf-2ed1-4467-88f5-3d0db1054548", "A bit pricey, but I love how it learns my preferences!", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 19, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5622), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "f3db8acd-5eec-4e36-8058-5018f3017095", "The screen is impressive, but the cooling performance could be better.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 29, 0, 24, 36, 575, DateTimeKind.Utc).AddTicks(5625), "fedcba98-7654-3210-fedc-ba9876543210" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "0aa2f487-11a3-4b8f-9a78-98398ac5ed38");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "0bb00d68-7025-4088-92b4-b291a6f517de");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "0ee1446b-61cc-4fda-b6b6-39c44dc13383");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "27e34283-9c2c-4242-9406-2aab6c6c7de3");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "44651b28-7943-4a34-ac30-98f8004c5ed5");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "4792492e-8f0a-4f48-a231-262cecbbe67b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "57c751e8-5143-477f-91be-319009751faa");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "5e3ae4cf-7975-40fc-a855-3f6592a0cfed");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "655c0623-f392-4df8-ada9-30757473e72c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "67d27aff-499d-43f7-bb81-331f05e4c34c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "6f4064c6-bbe9-4352-a67d-96df0112e0a4");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "6fe059ac-0df7-4ab8-92d7-bc4313551fd1");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "849b74e6-5bb8-440a-bc0d-ed17206ff5e9");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "859e6795-f7c8-45fe-b927-a989c1738448");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "8bbac066-b153-4ca7-8abd-acd94bfac3d3");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "9733ef2f-280c-4eeb-9e52-4a5ea2ed6ca4");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "aae0d2f7-eb79-4024-ab6c-dc4389df99e2");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b84caafd-54bd-4ac8-a19e-d49924ecf1f7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b8ef2a3f-89c8-4ac6-979c-b8535bf7d7bd");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "cdfb3c98-d34d-4f70-ac59-10632030647c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "cf2c16c7-c53c-42d0-a1b9-4e7f8e0fdb32");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "d451e862-24b7-4e4d-8741-e97437c2549b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "d781bb10-03ca-4d89-ad8e-24241b207231");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "d78d5faf-2ed1-4467-88f5-3d0db1054548");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f3db8acd-5eec-4e36-8058-5018f3017095");

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
        }
    }
}

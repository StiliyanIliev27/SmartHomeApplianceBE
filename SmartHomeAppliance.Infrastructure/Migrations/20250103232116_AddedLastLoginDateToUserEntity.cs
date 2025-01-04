using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedLastLoginDateToUserEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLoginDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11223344-5566-7788-99aa-bbccddeeff00",
                columns: new[] { "ConcurrencyStamp", "LastLoginDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b31dd254-f0f2-4268-8e45-f034c9cd3ce5", null, "AQAAAAIAAYagAAAAEPn277FSixdk5SsMJYHE3eduhHuai6WLGXIcsMs4l9pGvD1hLzMNWs4L2Rtku28OVg==", "bdadcc2f-f352-498e-a025-b10b28496b35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "LastLoginDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31753dfe-6f43-4aae-8488-3cfa62137ce9", null, "AQAAAAIAAYagAAAAEK91NIbrnnrlc3DgBfBmtPfO/SnIejrhsu4n/FwgfrSl9QNsjLY3HASfhujXKGBH8Q==", "c1d5c441-00fb-4b5a-9f9e-941fb9bd798a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "LastLoginDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdf0efb6-804a-4388-84a3-4fba160563e8", null, "AQAAAAIAAYagAAAAEMeFYPudIx6Y82+81bNvm+8FiI2pue3zSXvUiZcPoMGZsIRW6/PlbRXB0K1cztoueA==", "17f54d9d-4d8d-4aae-8820-f9ca280703d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890",
                columns: new[] { "ConcurrencyStamp", "LastLoginDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c02d37b-ecb4-4951-92ef-369eb6b0e3d9", null, "AQAAAAIAAYagAAAAEJmF35oR4BGH46sJUMU2hBdFRJxoqfRekb3KUmRgPYGkD0DNrsVFR3ToP7S3RzTuKA==", "7fe2877a-3958-4a67-a242-cc6e746b8366" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210",
                columns: new[] { "ConcurrencyStamp", "LastLoginDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cc2c9f3-0a7c-4945-b898-7402bc8709ec", null, "AQAAAAIAAYagAAAAEFOjaPz+bjBOC0rASSNdGftxJKyAGJhQda0xGg2g5Vn/ShLVnQ3VliMApw61pCP7Pw==", "77e7772d-2f23-4f5c-b9d6-3902594f57b4" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "398a846c-2b2c-4b01-90f2-55d342268673",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 23, 21, 14, 754, DateTimeKind.Utc).AddTicks(3404));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40941ea9-019c-415c-a101-9ccbc93a07d6",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 23, 21, 14, 754, DateTimeKind.Utc).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54a7eca8-ed42-4444-8522-d5a00310ed62",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 23, 21, 14, 754, DateTimeKind.Utc).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "668c6a85-f13f-43e9-b898-64d210b1cd45",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 23, 21, 14, 754, DateTimeKind.Utc).AddTicks(3391));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 23, 21, 14, 754, DateTimeKind.Utc).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "800a6ca2-3027-4a0f-ae72-0156405a6a58",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 23, 21, 14, 754, DateTimeKind.Utc).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 23, 21, 14, 754, DateTimeKind.Utc).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b109e70a-6b64-489f-a216-1d407abcf02f",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 23, 21, 14, 754, DateTimeKind.Utc).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 23, 21, 14, 754, DateTimeKind.Utc).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                column: "DateCreated",
                value: new DateTime(2025, 1, 3, 23, 21, 14, 754, DateTimeKind.Utc).AddTicks(3375));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { "04fd7fb6-e24e-47a0-ba86-8897be1f2934", "The weather-based feature works like a charm for my garden.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 26, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3654), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "143e9dbe-cd74-4425-9d5d-bf008a414542", "The screen is impressive, but the cooling performance could be better.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 29, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3815), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "1ac18200-b31b-4fc2-bcd1-0df7fe62e6a3", "A bit pricey, but I love how it learns my preferences!", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 19, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3813), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "1b3e0540-93c6-42db-b12a-fffd0989b733", "The robot vacuum works well on carpets and tiles but struggles with edges.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 4, new DateTime(2024, 12, 22, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3646), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "33d9b645-149b-410c-9e34-31d6ceb09815", "Fun to use and great for parties! The color-changing feature is amazing.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2024, 12, 29, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3644), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "5c5ca77e-6890-4c4d-bb90-8e16943a65e0", "Works well for basic needs, but advanced users may want more features.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 18, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3804), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "7497fc08-485a-4202-bbb7-af2f8abb1cfd", "Simple to use and very informative. A must-have for saving energy.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 4, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3827), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "7fb7f64b-1d66-4948-ade7-4553f4657a00", "The sprinkler system works well, but setup was confusing.", "398a846c-2b2c-4b01-90f2-55d342268673", 4, new DateTime(2024, 12, 12, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3825), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "89c42735-2f36-468e-8bcf-c28c8f2530e7", "The lights are fantastic, and the app is super intuitive.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2024, 12, 27, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3798), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "8e5abb20-d0b6-4113-b835-6874ef6941ec", "This thermostat was a game-changer for our energy bills.", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 9, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3652), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "9b5cc861-40ed-4149-a044-1b1890a92973", "The refrigerator is sleek, but I think it's overpriced for the features.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 19, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3639), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "b0f52740-bed9-4cc3-8e0f-bdb0732b4ccf", "Great for tracking my workouts, but the strap feels a bit cheap.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 22, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3821), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "b2d7867b-7db3-452b-ad9e-728d364b0188", "Accurate sleep tracking, but the battery life is shorter than expected.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 23, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3802), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "c3376946-9b21-4fc2-b0c5-dad258efe150", "Good hub, but it doesn't support some devices I own.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 16, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3823), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "cd3db29b-13b1-4bb6-918c-2dbd09495532", "The night vision is good, but the motion detection can be too sensitive.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 4, new DateTime(2024, 12, 20, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3790), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "d108e26c-f5a0-40d8-b9ef-009cd1ea07ad", "The lights are very bright and the app is easy to use.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 4, new DateTime(2024, 12, 14, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3810), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "d33a629e-06e7-4bf0-938c-5c6c4d6edc50", "This doorbell camera works great! The motion detection is very accurate.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 24, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3808), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "d61000ad-b416-4e52-8090-a5e188fd96ad", "Great design, but I wish the touch screen was more responsive.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 4, new DateTime(2024, 12, 12, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3793), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "daa29529-d2c1-4772-9e9b-556f0e0f417c", "Perfect for busy people. It cleans thoroughly and docks automatically.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 14, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3792), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "db8c0e91-7c69-42a3-bc1f-1027251b881f", "Easy to install and very efficient for garden watering.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 25, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3806), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "e577bb87-6ee3-4504-95f6-d58a3689acf0", "The hub has some lag when controlling multiple devices.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 4, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3787), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "e83d40af-f710-4d54-811d-0875d78f7d88", "I saved so much energy with this plug. The real-time monitoring is awesome.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 16, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3650), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "ecdce412-fc2b-4726-a382-6e7fa5d9144b", "I love how easy it is to set up this doorbell camera. The image quality is superb.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 24, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3633), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "f2a2a504-eb94-48fa-a393-34fda6e8d849", "This vacuum cleaner has saved me so much time. Highly recommend!", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 26, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3817), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "f9aec810-2024-4c7d-a949-50b12caad1d7", "A must-have fitness tracker for anyone serious about health.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 5, new DateTime(2024, 12, 14, 23, 21, 15, 49, DateTimeKind.Utc).AddTicks(3641), "12345678-9abc-def0-1234-56789abcdef0" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "04fd7fb6-e24e-47a0-ba86-8897be1f2934");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "143e9dbe-cd74-4425-9d5d-bf008a414542");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "1ac18200-b31b-4fc2-bcd1-0df7fe62e6a3");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "1b3e0540-93c6-42db-b12a-fffd0989b733");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "33d9b645-149b-410c-9e34-31d6ceb09815");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "5c5ca77e-6890-4c4d-bb90-8e16943a65e0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "7497fc08-485a-4202-bbb7-af2f8abb1cfd");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "7fb7f64b-1d66-4948-ade7-4553f4657a00");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "89c42735-2f36-468e-8bcf-c28c8f2530e7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "8e5abb20-d0b6-4113-b835-6874ef6941ec");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "9b5cc861-40ed-4149-a044-1b1890a92973");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b0f52740-bed9-4cc3-8e0f-bdb0732b4ccf");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b2d7867b-7db3-452b-ad9e-728d364b0188");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "c3376946-9b21-4fc2-b0c5-dad258efe150");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "cd3db29b-13b1-4bb6-918c-2dbd09495532");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "d108e26c-f5a0-40d8-b9ef-009cd1ea07ad");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "d33a629e-06e7-4bf0-938c-5c6c4d6edc50");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "d61000ad-b416-4e52-8090-a5e188fd96ad");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "daa29529-d2c1-4772-9e9b-556f0e0f417c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "db8c0e91-7c69-42a3-bc1f-1027251b881f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "e577bb87-6ee3-4504-95f6-d58a3689acf0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "e83d40af-f710-4d54-811d-0875d78f7d88");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ecdce412-fc2b-4726-a382-6e7fa5d9144b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f2a2a504-eb94-48fa-a393-34fda6e8d849");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f9aec810-2024-4c7d-a949-50b12caad1d7");

            migrationBuilder.DropColumn(
                name: "LastLoginDate",
                table: "AspNetUsers");

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
    }
}

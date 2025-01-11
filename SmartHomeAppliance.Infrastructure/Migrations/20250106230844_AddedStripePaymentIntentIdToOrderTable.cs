using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddedStripePaymentIntentIdToOrderTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "StripePaymentIntentId",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11223344-5566-7788-99aa-bbccddeeff00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb884e75-6adc-4a15-94af-66f95484242c", "AQAAAAIAAYagAAAAEMIYCbSRvTdl4nVmOSpjq0oi/3MqFd1oENqFPo7vZ0tAS/3BFt8c4sMfZsEo4vxq+Q==", "350d4573-7e7d-4263-9319-f4bd560fb13f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64064c02-dd87-46b3-8abe-a1f8b29f54ed", "AQAAAAIAAYagAAAAEEcCS8cTqaOPBSqtMjKnwjl/o9Rbf4PuBADogJDu36y6fEnfjk90DU+cHXPjIlScqQ==", "80d894db-bf3d-43cd-bc77-0661de5518eb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45424ff0-43c2-46c9-bbd6-1a1c0fac43f7", "AQAAAAIAAYagAAAAEI1bwe21lwJmN45pXImfxN4tG01C3Sqd2fUPlbs44mNKA+a/0HOsn592XRbBL01NpQ==", "3ab73b2f-4f29-4473-88f3-73c0e1f23eb1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f2befc85-8b09-4198-b914-8edc76626641", "AQAAAAIAAYagAAAAEFEh+eqDsbPPUi0rLIw8H6xAOLoP8bd8rin4PjUPpMMt66VOqP5SdlZ4PLhHp9BXOQ==", "6e970bec-a386-4687-b863-2864a4f8b6dc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f7bc459-66b4-4ab3-81cd-9edd0e911389", "AQAAAAIAAYagAAAAEOF102VWcjO+VXNj9hASfWFerqF5Ce/KD7UiR57pOlCjO91OVwsDqq9EEJNImlrQaA==", "2ec4158f-f682-45de-a42b-ef5304710cd2" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "398a846c-2b2c-4b01-90f2-55d342268673",
                column: "DateCreated",
                value: new DateTime(2025, 1, 6, 23, 8, 42, 395, DateTimeKind.Utc).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40941ea9-019c-415c-a101-9ccbc93a07d6",
                column: "DateCreated",
                value: new DateTime(2025, 1, 6, 23, 8, 42, 395, DateTimeKind.Utc).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54a7eca8-ed42-4444-8522-d5a00310ed62",
                column: "DateCreated",
                value: new DateTime(2025, 1, 6, 23, 8, 42, 395, DateTimeKind.Utc).AddTicks(1485));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "668c6a85-f13f-43e9-b898-64d210b1cd45",
                column: "DateCreated",
                value: new DateTime(2025, 1, 6, 23, 8, 42, 395, DateTimeKind.Utc).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                column: "DateCreated",
                value: new DateTime(2025, 1, 6, 23, 8, 42, 395, DateTimeKind.Utc).AddTicks(1495));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "800a6ca2-3027-4a0f-ae72-0156405a6a58",
                column: "DateCreated",
                value: new DateTime(2025, 1, 6, 23, 8, 42, 395, DateTimeKind.Utc).AddTicks(1488));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
                column: "DateCreated",
                value: new DateTime(2025, 1, 6, 23, 8, 42, 395, DateTimeKind.Utc).AddTicks(1491));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b109e70a-6b64-489f-a216-1d407abcf02f",
                column: "DateCreated",
                value: new DateTime(2025, 1, 6, 23, 8, 42, 395, DateTimeKind.Utc).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                column: "DateCreated",
                value: new DateTime(2025, 1, 6, 23, 8, 42, 395, DateTimeKind.Utc).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                column: "DateCreated",
                value: new DateTime(2025, 1, 6, 23, 8, 42, 395, DateTimeKind.Utc).AddTicks(1474));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { "02a63382-10ad-43d2-a9c6-3fa5608d60e6", "I saved so much energy with this plug. The real-time monitoring is awesome.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 19, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2204), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "0588bdc8-5d86-47bd-bb77-bcef1b3e2ec6", "This doorbell camera works great! The motion detection is very accurate.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 27, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2225), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "0ff9f0e8-305b-4895-acff-430f76e9f2c1", "Simple to use and very informative. A must-have for saving energy.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 7, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2242), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "1dd3a059-c0d3-4289-8e22-894d4ad6638f", "The night vision is good, but the motion detection can be too sensitive.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 4, new DateTime(2024, 12, 23, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2212), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "2bff549c-c37d-49b6-b4f9-4228036c4103", "The sprinkler system works well, but setup was confusing.", "398a846c-2b2c-4b01-90f2-55d342268673", 4, new DateTime(2024, 12, 15, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2240), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "339eba07-934b-4083-8c09-6a37c82db243", "Fun to use and great for parties! The color-changing feature is amazing.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2025, 1, 1, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2197), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "526ca0fb-f006-4801-8b90-b6c05473a842", "The screen is impressive, but the cooling performance could be better.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2025, 1, 1, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2232), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "616dc39e-0291-4f52-8df2-671dcdfa528b", "The robot vacuum works well on carpets and tiles but struggles with edges.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 4, new DateTime(2024, 12, 25, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2201), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "62a24c8e-85d4-4153-bab8-ee90431dcfc0", "Great for tracking my workouts, but the strap feels a bit cheap.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 25, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2237), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "64b700b0-d702-4c04-89b0-e9d11e36eee5", "The hub has some lag when controlling multiple devices.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 7, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2210), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "72dcba16-179b-44f1-8002-4075767cd96e", "The lights are very bright and the app is easy to use.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 4, new DateTime(2024, 12, 17, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2227), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "78db4c18-bf80-44b1-9de7-68238a042306", "Great design, but I wish the touch screen was more responsive.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 4, new DateTime(2024, 12, 15, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2215), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "8e985a7c-7b1d-4a21-8518-6290ddf6231d", "This thermostat was a game-changer for our energy bills.", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 12, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2206), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "8ea33342-47be-466e-90c7-edaa79b3f27f", "The weather-based feature works like a charm for my garden.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 29, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2207), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "9204bd35-a297-4304-a58a-e03b5d46fac8", "Good hub, but it doesn't support some devices I own.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 19, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2239), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "9b77bb72-df97-4a9f-95b9-418882e4970f", "Accurate sleep tracking, but the battery life is shorter than expected.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 26, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2220), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "b389a788-0b47-4586-9a02-77a4189c8d19", "I love how easy it is to set up this doorbell camera. The image quality is superb.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 27, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2189), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "b49681ea-8e20-4197-b850-b7fe8c9ad27b", "The refrigerator is sleek, but I think it's overpriced for the features.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 22, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2193), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "b5981f74-056f-4fe9-8383-c304c30e9b87", "Perfect for busy people. It cleans thoroughly and docks automatically.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 17, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2213), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "be549113-2b62-49bd-98b8-c459082ab75c", "A bit pricey, but I love how it learns my preferences!", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 22, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2230), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "dd69cb69-ec1f-4365-83ef-6a75052ff0f8", "Easy to install and very efficient for garden watering.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 28, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2224), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "df61149a-8b6c-4b1b-9c31-59cf01a74a35", "A must-have fitness tracker for anyone serious about health.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 5, new DateTime(2024, 12, 17, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2195), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "ec1c3220-b536-439e-8d26-84837a8b1562", "The lights are fantastic, and the app is super intuitive.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2024, 12, 30, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2219), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "fd7d1cfd-b18e-48bd-a29c-40f45e7b1e94", "This vacuum cleaner has saved me so much time. Highly recommend!", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 29, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2235), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "ffaa9ce9-7509-4538-b831-a554cd0abd38", "Works well for basic needs, but advanced users may want more features.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 21, 23, 8, 42, 620, DateTimeKind.Utc).AddTicks(2222), "fedcba98-7654-3210-fedc-ba9876543210" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "02a63382-10ad-43d2-a9c6-3fa5608d60e6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "0588bdc8-5d86-47bd-bb77-bcef1b3e2ec6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "0ff9f0e8-305b-4895-acff-430f76e9f2c1");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "1dd3a059-c0d3-4289-8e22-894d4ad6638f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "2bff549c-c37d-49b6-b4f9-4228036c4103");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "339eba07-934b-4083-8c09-6a37c82db243");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "526ca0fb-f006-4801-8b90-b6c05473a842");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "616dc39e-0291-4f52-8df2-671dcdfa528b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "62a24c8e-85d4-4153-bab8-ee90431dcfc0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "64b700b0-d702-4c04-89b0-e9d11e36eee5");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "72dcba16-179b-44f1-8002-4075767cd96e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "78db4c18-bf80-44b1-9de7-68238a042306");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "8e985a7c-7b1d-4a21-8518-6290ddf6231d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "8ea33342-47be-466e-90c7-edaa79b3f27f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "9204bd35-a297-4304-a58a-e03b5d46fac8");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "9b77bb72-df97-4a9f-95b9-418882e4970f");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b389a788-0b47-4586-9a02-77a4189c8d19");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b49681ea-8e20-4197-b850-b7fe8c9ad27b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b5981f74-056f-4fe9-8383-c304c30e9b87");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "be549113-2b62-49bd-98b8-c459082ab75c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "dd69cb69-ec1f-4365-83ef-6a75052ff0f8");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "df61149a-8b6c-4b1b-9c31-59cf01a74a35");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ec1c3220-b536-439e-8d26-84837a8b1562");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "fd7d1cfd-b18e-48bd-a29c-40f45e7b1e94");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ffaa9ce9-7509-4538-b831-a554cd0abd38");

            migrationBuilder.DropColumn(
                name: "StripePaymentIntentId",
                table: "Orders");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11223344-5566-7788-99aa-bbccddeeff00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b31dd254-f0f2-4268-8e45-f034c9cd3ce5", "AQAAAAIAAYagAAAAEPn277FSixdk5SsMJYHE3eduhHuai6WLGXIcsMs4l9pGvD1hLzMNWs4L2Rtku28OVg==", "bdadcc2f-f352-498e-a025-b10b28496b35" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31753dfe-6f43-4aae-8488-3cfa62137ce9", "AQAAAAIAAYagAAAAEK91NIbrnnrlc3DgBfBmtPfO/SnIejrhsu4n/FwgfrSl9QNsjLY3HASfhujXKGBH8Q==", "c1d5c441-00fb-4b5a-9f9e-941fb9bd798a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdf0efb6-804a-4388-84a3-4fba160563e8", "AQAAAAIAAYagAAAAEMeFYPudIx6Y82+81bNvm+8FiI2pue3zSXvUiZcPoMGZsIRW6/PlbRXB0K1cztoueA==", "17f54d9d-4d8d-4aae-8820-f9ca280703d9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6c02d37b-ecb4-4951-92ef-369eb6b0e3d9", "AQAAAAIAAYagAAAAEJmF35oR4BGH46sJUMU2hBdFRJxoqfRekb3KUmRgPYGkD0DNrsVFR3ToP7S3RzTuKA==", "7fe2877a-3958-4a67-a242-cc6e746b8366" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9cc2c9f3-0a7c-4945-b898-7402bc8709ec", "AQAAAAIAAYagAAAAEFOjaPz+bjBOC0rASSNdGftxJKyAGJhQda0xGg2g5Vn/ShLVnQ3VliMApw61pCP7Pw==", "77e7772d-2f23-4f5c-b9d6-3902594f57b4" });

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
    }
}

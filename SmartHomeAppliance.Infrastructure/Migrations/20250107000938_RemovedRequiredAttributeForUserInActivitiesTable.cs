using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemovedRequiredAttributeForUserInActivitiesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_AspNetUsers_UserId",
                table: "Activities");

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

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Activities",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_AspNetUsers_UserId",
                table: "Activities",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_AspNetUsers_UserId",
                table: "Activities");

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

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Activities",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_AspNetUsers_UserId",
                table: "Activities",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11223344-5566-7788-99aa-bbccddeeff00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fbc6e29b-58db-41eb-8f8e-0c0e2145aeb4", "AQAAAAIAAYagAAAAEFOVc++USnESB4g4aV2BU7mQWGH/BuyZ5kObZdIuPL9Izpaeb3PB/Is7GEdbK+NQEQ==", "ee87469d-1373-4356-afa4-bb921485715b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33db7f0d-1203-45d5-96d5-e2706364378a", "AQAAAAIAAYagAAAAEBUNkxR2M8DXO8XbR0P3mGSHYyZQkIVu9Ao6u5dRlf50IMudQf+sZDL5bx/KDH4Zyw==", "64a23287-0072-429e-9d94-8eaa253da861" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "597f428d-9a53-45f5-b8f7-6680c18df7a6", "AQAAAAIAAYagAAAAEK9RkM/JSwCTDJTJBsiclu4q93Mn4kkYfos8zw/VcuYXfORa8q6OD31T5GL9vNBwcw==", "8fa4923f-d84f-4b45-91e5-54f3f9f3eef7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b99df1b-284f-412f-a2a3-9847d4de98b4", "AQAAAAIAAYagAAAAEIkkszsQOS5BHsoAgrOosLK1Vff+ecCijAyaUc6DUMB0a5G5za0wCE/ojWRPLR8UeQ==", "d4f1ddda-e7cc-4d37-9e02-e1dada1fd0c2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56cf4790-aae6-4058-82bb-7bd25e801686", "AQAAAAIAAYagAAAAEL3as7Q59Ra0/JSPI6uG65k+6QC6OkpSwi675pM+6VxNIXeDBPm29t7PTU0WUWhsLQ==", "795269bb-a39b-43eb-bf2e-8193dc2da8b5" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "398a846c-2b2c-4b01-90f2-55d342268673",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 10, 27, 412, DateTimeKind.Utc).AddTicks(9292));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40941ea9-019c-415c-a101-9ccbc93a07d6",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 10, 27, 412, DateTimeKind.Utc).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54a7eca8-ed42-4444-8522-d5a00310ed62",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 10, 27, 412, DateTimeKind.Utc).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "668c6a85-f13f-43e9-b898-64d210b1cd45",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 10, 27, 412, DateTimeKind.Utc).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 10, 27, 412, DateTimeKind.Utc).AddTicks(9084));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "800a6ca2-3027-4a0f-ae72-0156405a6a58",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 10, 27, 412, DateTimeKind.Utc).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 10, 27, 412, DateTimeKind.Utc).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b109e70a-6b64-489f-a216-1d407abcf02f",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 10, 27, 412, DateTimeKind.Utc).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 10, 27, 412, DateTimeKind.Utc).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 10, 27, 412, DateTimeKind.Utc).AddTicks(9044));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { "0082593a-a0b0-4cdc-8231-816de342a2ae", "The hub has some lag when controlling multiple devices.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 11, 26, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7344), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "297995cf-cdd4-432f-b5b9-aa59fed2d25c", "Good hub, but it doesn't support some devices I own.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 8, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7417), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "39b824a3-14d8-4dbf-8fb5-2cf62ee34102", "This thermostat was a game-changer for our energy bills.", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 1, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7333), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "3a9ba814-4de7-427d-8042-eb87b8f21c4b", "Works well for basic needs, but advanced users may want more features.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 10, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7374), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "3ca7b861-1c6e-437a-a7d6-4c19cd072b6d", "Accurate sleep tracking, but the battery life is shorter than expected.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 15, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7369), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "40c7f449-5ce8-4a6c-aace-eaf2840b6d38", "The screen is impressive, but the cooling performance could be better.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 21, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7404), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "43cd0706-5f38-4433-b1ef-f925d95f0af9", "I saved so much energy with this plug. The real-time monitoring is awesome.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 8, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7329), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "4cb0a009-8cdb-439d-a2df-243b2476b631", "Easy to install and very efficient for garden watering.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 17, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7378), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "70adea56-b271-4b0e-870f-150ee28b5f60", "This doorbell camera works great! The motion detection is very accurate.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 16, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7383), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "7b803a81-b355-43e2-9fb3-f71eaafd360a", "The sprinkler system works well, but setup was confusing.", "398a846c-2b2c-4b01-90f2-55d342268673", 4, new DateTime(2024, 12, 4, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7421), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "8631d111-e4da-44f5-9945-af40f232df1c", "Great for tracking my workouts, but the strap feels a bit cheap.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 14, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7413), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "a6099afd-5a8c-42be-82e5-1f5e117cf3c1", "The weather-based feature works like a charm for my garden.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 18, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7337), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "b236b4c9-0d41-450d-a608-239bea799d13", "I love how easy it is to set up this doorbell camera. The image quality is superb.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 16, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7141), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "ba46a02d-2d0b-4db4-8b19-9c4c9d03a4e6", "The lights are fantastic, and the app is super intuitive.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2024, 12, 19, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7365), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "cc256d51-d345-4c47-9c0a-dbc4944a13b8", "Perfect for busy people. It cleans thoroughly and docks automatically.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 6, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7353), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "cc7ae2d3-1c7d-40d9-8df2-2c68cd2f98a2", "The refrigerator is sleek, but I think it's overpriced for the features.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 11, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7153), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "cee3a220-648e-48a1-b7b9-95f8af918254", "The robot vacuum works well on carpets and tiles but struggles with edges.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 4, new DateTime(2024, 12, 14, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7323), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "da18a473-2a6d-4387-a001-849762a3c9f9", "The night vision is good, but the motion detection can be too sensitive.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 4, new DateTime(2024, 12, 12, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7349), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "df076ec1-db8e-4e08-973b-80ee1824e291", "This vacuum cleaner has saved me so much time. Highly recommend!", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 18, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7409), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "e24364bd-5fb7-4f31-b437-be81ca1b4f74", "Fun to use and great for parties! The color-changing feature is amazing.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2024, 12, 21, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7170), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "e6bff44f-e351-4c41-9a29-abfb746ef28c", "Great design, but I wish the touch screen was more responsive.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 4, new DateTime(2024, 12, 4, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7361), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "e8fd431e-370e-46fa-87c6-77c6f5bbe595", "Simple to use and very informative. A must-have for saving energy.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 11, 26, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7424), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "ec5e0659-506d-4d7a-b7f6-675ef77b695c", "A must-have fitness tracker for anyone serious about health.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 5, new DateTime(2024, 12, 6, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7158), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "ecb83388-720d-496b-b5e7-1b6a0d58ed39", "The lights are very bright and the app is easy to use.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 4, new DateTime(2024, 12, 6, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7387), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "fac732c0-0355-48ea-b0c2-bfa699c1df22", "A bit pricey, but I love how it learns my preferences!", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 11, 12, 10, 28, 28, DateTimeKind.Utc).AddTicks(7396), "11223344-5566-7788-99aa-bbccddeeff00" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "0082593a-a0b0-4cdc-8231-816de342a2ae");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "297995cf-cdd4-432f-b5b9-aa59fed2d25c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "39b824a3-14d8-4dbf-8fb5-2cf62ee34102");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "3a9ba814-4de7-427d-8042-eb87b8f21c4b");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "3ca7b861-1c6e-437a-a7d6-4c19cd072b6d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "40c7f449-5ce8-4a6c-aace-eaf2840b6d38");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "43cd0706-5f38-4433-b1ef-f925d95f0af9");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "4cb0a009-8cdb-439d-a2df-243b2476b631");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "70adea56-b271-4b0e-870f-150ee28b5f60");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "7b803a81-b355-43e2-9fb3-f71eaafd360a");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "8631d111-e4da-44f5-9945-af40f232df1c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "a6099afd-5a8c-42be-82e5-1f5e117cf3c1");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b236b4c9-0d41-450d-a608-239bea799d13");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ba46a02d-2d0b-4db4-8b19-9c4c9d03a4e6");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "cc256d51-d345-4c47-9c0a-dbc4944a13b8");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "cc7ae2d3-1c7d-40d9-8df2-2c68cd2f98a2");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "cee3a220-648e-48a1-b7b9-95f8af918254");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "da18a473-2a6d-4387-a001-849762a3c9f9");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "df076ec1-db8e-4e08-973b-80ee1824e291");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "e24364bd-5fb7-4f31-b437-be81ca1b4f74");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "e6bff44f-e351-4c41-9a29-abfb746ef28c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "e8fd431e-370e-46fa-87c6-77c6f5bbe595");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ec5e0659-506d-4d7a-b7f6-675ef77b695c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ecb83388-720d-496b-b5e7-1b6a0d58ed39");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "fac732c0-0355-48ea-b0c2-bfa699c1df22");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11223344-5566-7788-99aa-bbccddeeff00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d400eec8-c41d-4b19-804e-22e7b363cb8c", "AQAAAAIAAYagAAAAENnRFRcKxEnpsLxQ3CzO1okdjlJUQGRFHKkdQ2YMl8uEOIcicbCsZYPWxx3YchlBkA==", "28d51c9c-eaf0-471c-9734-038744476b29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63ad0394-0413-4e27-a273-58b74e19fd6e", "AQAAAAIAAYagAAAAEJ5nhuCWQozo4kkFRBU2qwwr7rLBcfAbvVjMh9Wnyi+uZutxlTLdzu2K1wk4FM879w==", "63ea1173-d0cd-49c3-a4a9-2f9d85826f29" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3a6b4eb-ddf7-47ea-8b1e-06993fa6710d", "AQAAAAIAAYagAAAAEIsj6U3iHY9LyZDXz965+ZztigL7kTR2CHMKEbZb9lNIj/2jtlKmgWxIB1kAuq2NKg==", "ad4b8b93-f2cd-4404-883d-ca78fae7c125" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d0fa79f2-bce4-4709-b378-617e89f42560", "AQAAAAIAAYagAAAAEAk0AH7nRiWfW092vZCxsprdS1d9Hi0MA9IJssnQkyw1rpOS175Ogg2NuLj4EuaM9g==", "fd7f82ee-53e9-45b6-bafa-e441f9c294e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e735dd9f-a26b-489a-9c69-a8394c7dd5e6", "AQAAAAIAAYagAAAAEGVLhdjRoP8jAHUp9TFqPJxGSz4me2q8FUZuCdhMdfQ2EJqW7L6GppTkXEYmVJ4M2A==", "31473c00-d005-4492-976e-7537699fff67" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "398a846c-2b2c-4b01-90f2-55d342268673",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5894));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40941ea9-019c-415c-a101-9ccbc93a07d6",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5836));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54a7eca8-ed42-4444-8522-d5a00310ed62",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5850));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "668c6a85-f13f-43e9-b898-64d210b1cd45",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "800a6ca2-3027-4a0f-ae72-0156405a6a58",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5857));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5861));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b109e70a-6b64-489f-a216-1d407abcf02f",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5818));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                column: "DateCreated",
                value: new DateTime(2024, 12, 26, 12, 8, 54, 726, DateTimeKind.Utc).AddTicks(5830));
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedJohnDoeProfilePicture : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "443c19c8-9f36-407b-bd77-aa0f5c1714be", "AQAAAAIAAYagAAAAEP1wHZgrUqj20UIex7x+gpinEaQKsobUg7gVX7hSdocytHMhCxE3/8wZ96JRRqbN0g==", "f1a46110-9a1a-4d0d-9850-b15e550474f9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "323940a4-3947-4460-9ace-203935b9625c", "AQAAAAIAAYagAAAAEDGExgbNF6IxPl4nxgkynQVQHZzJv4YeNNc61j33pCNOsoQlnMmB2MV7sTdz+ewOpA==", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSGiRJA_5DqmVm7TxMV7E0IzYzUujF4p3SHPg&s", "c41799af-1a1f-4591-8190-29e5cdda3ca8" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "ProfilePictureUrl", "SecurityStamp" },
                values: new object[] { "33db7f0d-1203-45d5-96d5-e2706364378a", "AQAAAAIAAYagAAAAEBUNkxR2M8DXO8XbR0P3mGSHYyZQkIVu9Ao6u5dRlf50IMudQf+sZDL5bx/KDH4Zyw==", "https://images.unsplash.com/photo-1502720705749-3c53d2b6dc34", "64a23287-0072-429e-9d94-8eaa253da861" });

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
    }
}

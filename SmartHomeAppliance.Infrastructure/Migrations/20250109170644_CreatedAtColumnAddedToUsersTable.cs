using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class CreatedAtColumnAddedToUsersTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "23f50cb0-1b21-4d71-824b-4bfe3fdaa104");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "30b3701f-02bb-41da-b815-e3b2cdad50b4");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "3159d948-f326-47ab-8e32-6b8c0ab3913d");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "4aeed923-3355-4fe3-9496-74c1eb276c15");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "4bed9d30-a191-4001-b4eb-1893f235407e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "4d6dc680-957b-421e-b63f-2e1d788ddd35");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "61f91ea8-46e8-427d-9cd8-7e0320e113a0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "6a714165-94b8-44ff-8b0b-c9a3a7f40779");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "6b439061-63b9-4631-9641-69bb0b7f764e");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "93487c7a-506b-4089-93cd-90471bd0babc");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "adca0d27-43f5-48d4-9f9c-51f8d363fa36");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "b3974467-aae5-4d5d-8341-eb78afda334a");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "bbf27d0e-360c-4ee5-98f1-d1bae28c31e9");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "c380984c-a10b-4722-a2b0-dda837ad5865");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ce918b4d-4fd2-4b60-9b32-b3cdf44f055c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ceda02e1-209d-483b-b8c6-9df6c8d82182");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "cf9b662d-b797-44ec-841b-990f7cc3b6e7");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "d72f6fbc-7b87-4ea1-80c1-186fdc84c83c");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "e3b98e03-3613-4e73-ad00-9b707f937ae0");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "eb26646e-7739-4026-9037-a751664a69cb");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "ed60ed6c-0904-4f2d-8df5-1940cf4c7dda");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f3116a04-459e-426f-bf8e-57b1a8d120f8");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "f3b39011-fdcd-4e20-a7ea-de003bd93f47");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "fd2d8593-d13f-4642-9cd9-20627f8dd8b9");

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: "fdf3aaad-102e-4ba8-a18c-9c9cb359610f");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11223344-5566-7788-99aa-bbccddeeff00",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "577bf531-35ca-4316-9ef9-086c389d44dd", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAIAAYagAAAAEPVb156qnW8ZTXptN1PvClJ+iIAtmWUaLF0VSmqYxOcL1raZbcNB6IEsdAy1Oy4Szw==", "b5009512-2418-4865-a7b6-36fbde674f19" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf4a15b7-f4d3-4981-9b01-61f1d4da89a8", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAIAAYagAAAAEMi4HJDU1YjGb0ueRlCQoJOeEJ9rDdH55al7tb/0PehGHfF+Mqc4tpPt1B/TlrGUUg==", "0c145999-9ec1-4170-9184-9bd495dcb68a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c5adec8-f97e-4d50-a053-6c405cfba796", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAIAAYagAAAAEBf+EWaIoso8XlNf1nWgtOTjQS4176ABdCnAujYAmErHXveBO8YFhqXW1EmMOs7Hqg==", "7ef7f3ce-368d-4ec6-abe1-2ca7aa161985" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "914bddd5-2263-4398-9d75-51780d47a219", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAIAAYagAAAAEGs80KYgr2GOCjwFNWOcxHF4IiT6UHXxt3DNLAQU/VzmSI5QJXhfIDtVKcIa7etEow==", "194dd5d6-2fd5-4910-8bfc-1248ca97e071" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44b50b11-fbcd-4b29-8ee8-40021394b0b9", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAIAAYagAAAAEBFXgZ+eK5ceDI8r4Jie9XGzaKY7Q3eDs3ocxIDOcJQrHDNs+D8AHnDZ4sHdGi7R5g==", "a6d48759-0962-4f06-bdad-b36f21eb7825" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11223344-5566-7788-99aa-bbccddeeff00",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4acefc67-546f-418e-81b6-ec10295ef9e3", "AQAAAAIAAYagAAAAEOsubUtXWsKUocjWO22ggAOERS/ZGSluBH6SqxFXCPM48Hd3Va9D6QUbOiXxXNmWmQ==", "cd6d26c9-34b9-4274-b2ae-99d950c8a1a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "12345678-9abc-def0-1234-56789abcdef0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2dba3bf0-160a-4f95-8898-6cd95fb578c8", "AQAAAAIAAYagAAAAEJIdtlQXTvkh39V9UAsPuTpPqwGdhPyDchpFBLb8iVyjpTK0RlnuupPuLvJ8hTiRUA==", "280f3361-0faf-4829-81c8-387efec60fd9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c38d05ca-a49a-4a1f-900b-ec004d9e2b41", "AQAAAAIAAYagAAAAEPz4SlWFYPkqEmXiQtGP85EO4I8K2jRC48Zz5jexmwDrSGEgRTLpvJGRTDoVSATd4w==", "36526246-2176-4d1b-8221-25869e9ac630" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "abcdef12-3456-7890-abcd-ef1234567890",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76046da4-7eb4-4e53-8838-54c0af565e39", "AQAAAAIAAYagAAAAEJFbCqgZ4dCJocCgIQHDAOzEKNBGeFJSse10wGj9V8b89hIi8T+DcyogXqDRdrCcZA==", "e9659a4e-5fd3-4f01-a1cb-cf310fe540d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fedcba98-7654-3210-fedc-ba9876543210",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2919413f-1944-478a-9375-68885c8ce21e", "AQAAAAIAAYagAAAAEMGIVE5VMVK5aqLqKU4O71a2c/arnHutA2UCWitldV5rU0On/UxT6XxWCOJRi6ZANQ==", "f5c39607-8e04-47b2-8730-1e44a27ad171" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "398a846c-2b2c-4b01-90f2-55d342268673",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "40941ea9-019c-415c-a101-9ccbc93a07d6",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "54a7eca8-ed42-4444-8522-d5a00310ed62",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "668c6a85-f13f-43e9-b898-64d210b1cd45",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "7be0663a-6953-44a8-9d06-80f1d72ce6b3",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "800a6ca2-3027-4a0f-ae72-0156405a6a58",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4181));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "a2fa3f78-c2ce-44ae-8b3f-402f54563b30",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "b109e70a-6b64-489f-a216-1d407abcf02f",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "d39a7ae3-78c5-40ae-8569-34a0454dc909",
                column: "DateCreated",
                value: new DateTime(2025, 1, 8, 12, 10, 39, 603, DateTimeKind.Utc).AddTicks(4155));

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "ProductId", "Rating", "ReviewDate", "UserId" },
                values: new object[,]
                {
                    { "23f50cb0-1b21-4d71-824b-4bfe3fdaa104", "The hub has some lag when controlling multiple devices.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 9, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8057), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "30b3701f-02bb-41da-b815-e3b2cdad50b4", "The lights are fantastic, and the app is super intuitive.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2025, 1, 1, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8066), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "3159d948-f326-47ab-8e32-6b8c0ab3913d", "Good hub, but it doesn't support some devices I own.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 21, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8088), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "4aeed923-3355-4fe3-9496-74c1eb276c15", "Simple to use and very informative. A must-have for saving energy.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 9, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8092), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "4bed9d30-a191-4001-b4eb-1893f235407e", "The sprinkler system works well, but setup was confusing.", "398a846c-2b2c-4b01-90f2-55d342268673", 4, new DateTime(2024, 12, 17, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8090), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "4d6dc680-957b-421e-b63f-2e1d788ddd35", "Easy to install and very efficient for garden watering.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 30, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8072), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "61f91ea8-46e8-427d-9cd8-7e0320e113a0", "This vacuum cleaner has saved me so much time. Highly recommend!", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 31, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8084), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "6a714165-94b8-44ff-8b0b-c9a3a7f40779", "I saved so much energy with this plug. The real-time monitoring is awesome.", "a2fa3f78-c2ce-44ae-8b3f-402f54563b30", 5, new DateTime(2024, 12, 21, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8050), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "6b439061-63b9-4631-9641-69bb0b7f764e", "The weather-based feature works like a charm for my garden.", "398a846c-2b2c-4b01-90f2-55d342268673", 5, new DateTime(2024, 12, 31, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8054), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "93487c7a-506b-4089-93cd-90471bd0babc", "The robot vacuum works well on carpets and tiles but struggles with edges.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 4, new DateTime(2024, 12, 27, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8048), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "adca0d27-43f5-48d4-9f9c-51f8d363fa36", "Great for tracking my workouts, but the strap feels a bit cheap.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 27, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8086), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "b3974467-aae5-4d5d-8341-eb78afda334a", "A must-have fitness tracker for anyone serious about health.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 5, new DateTime(2024, 12, 19, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8038), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "bbf27d0e-360c-4ee5-98f1-d1bae28c31e9", "Fun to use and great for parties! The color-changing feature is amazing.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 5, new DateTime(2025, 1, 3, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8043), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "c380984c-a10b-4722-a2b0-dda837ad5865", "This doorbell camera works great! The motion detection is very accurate.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 29, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8074), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "ce918b4d-4fd2-4b60-9b32-b3cdf44f055c", "Accurate sleep tracking, but the battery life is shorter than expected.", "7be0663a-6953-44a8-9d06-80f1d72ce6b3", 4, new DateTime(2024, 12, 28, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8068), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "ceda02e1-209d-483b-b8c6-9df6c8d82182", "Perfect for busy people. It cleans thoroughly and docks automatically.", "668c6a85-f13f-43e9-b898-64d210b1cd45", 5, new DateTime(2024, 12, 19, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8061), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "cf9b662d-b797-44ec-841b-990f7cc3b6e7", "The lights are very bright and the app is easy to use.", "d39a7ae3-78c5-40ae-8569-34a0454dc909", 4, new DateTime(2024, 12, 19, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8076), "abcdef12-3456-7890-abcd-ef1234567890" },
                    { "d72f6fbc-7b87-4ea1-80c1-186fdc84c83c", "Works well for basic needs, but advanced users may want more features.", "b109e70a-6b64-489f-a216-1d407abcf02f", 3, new DateTime(2024, 12, 23, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8070), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "e3b98e03-3613-4e73-ad00-9b707f937ae0", "This thermostat was a game-changer for our energy bills.", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 14, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8052), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "eb26646e-7739-4026-9037-a751664a69cb", "I love how easy it is to set up this doorbell camera. The image quality is superb.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 5, new DateTime(2024, 12, 29, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8031), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "ed60ed6c-0904-4f2d-8df5-1940cf4c7dda", "The night vision is good, but the motion detection can be too sensitive.", "c5a8a95c-0fe5-4f7d-9e46-0ad9fabf78ec", 4, new DateTime(2024, 12, 25, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8059), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "f3116a04-459e-426f-bf8e-57b1a8d120f8", "The screen is impressive, but the cooling performance could be better.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2025, 1, 3, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8082), "fedcba98-7654-3210-fedc-ba9876543210" },
                    { "f3b39011-fdcd-4e20-a7ea-de003bd93f47", "The refrigerator is sleek, but I think it's overpriced for the features.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 3, new DateTime(2024, 12, 24, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8036), "12345678-9abc-def0-1234-56789abcdef0" },
                    { "fd2d8593-d13f-4642-9cd9-20627f8dd8b9", "A bit pricey, but I love how it learns my preferences!", "40941ea9-019c-415c-a101-9ccbc93a07d6", 5, new DateTime(2024, 12, 24, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8079), "11223344-5566-7788-99aa-bbccddeeff00" },
                    { "fdf3aaad-102e-4ba8-a18c-9c9cb359610f", "Great design, but I wish the touch screen was more responsive.", "54a7eca8-ed42-4444-8522-d5a00310ed62", 4, new DateTime(2024, 12, 17, 12, 10, 39, 963, DateTimeKind.Utc).AddTicks(8064), "11223344-5566-7788-99aa-bbccddeeff00" }
                });
        }
    }
}

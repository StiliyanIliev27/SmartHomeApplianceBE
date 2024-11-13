using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartHomeAppliance.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UsersRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4f8554d2-cfaa-44b5-90ce-e883c804ae90", "4f8554d2-cfaa-44b5-90ce-e883c804ae90", "User", "USER" },
                    { "656a6079-ec9a-4a98-a484-2d1752156d60", "656a6079-ec9a-4a98-a484-2d1752156d60", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePictureUrl", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "27d78708-8671-4b05-bd5e-17aa91392224", 0, "b5320d52-d71f-492a-9ea5-8c390286da3a", "admin@smarthomeapp.bg", true, "Admin", "Adminov", false, null, "ADMIN@SMARTHOMEAPP.BG", null, "AQAAAAIAAYagAAAAENZP7zEUGIQb2Dq106Tnjpln+8q4KPe8dGdJAjUulWnBZVvuWH7wMostkw48Xl0wGg==", null, false, "https://plus.unsplash.com/premium_photo-1689530775582-83b8abdb5020?q=80&w=2670&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D", "dfc3b10c-01a0-4039-b41d-105d7ddb092c", false, null });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "656a6079-ec9a-4a98-a484-2d1752156d60", "27d78708-8671-4b05-bd5e-17aa91392224" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f8554d2-cfaa-44b5-90ce-e883c804ae90");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "656a6079-ec9a-4a98-a484-2d1752156d60", "27d78708-8671-4b05-bd5e-17aa91392224" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "656a6079-ec9a-4a98-a484-2d1752156d60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27d78708-8671-4b05-bd5e-17aa91392224");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace Steda_backend.Migrations
{
    public partial class LoginMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "Photos",
                keyColumn: "PhotoID",
                keyValue: 10);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "56df1e4d-b434-4494-a597-ccb9257e8140", "Stefan", "stefantimosenco@gmail.com", false, false, null, null, null, "Pa$$word", null, false, "2bd3e584-da14-463f-a636-b8710123579c", false, "stefan.timosenco" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DisplayName", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2", 0, "d3eae147-bfe4-4479-b4bf-7ef89d31a62c", "Dana", "daniela.andries26@gmail.com", false, false, null, null, null, "Pa$$word", null, false, "cc47eccd-58a7-4e5f-a07e-fd964878e4ed", false, "daniela.andries" });

            migrationBuilder.InsertData(
                table: "Photos",
                columns: new[] { "PhotoID", "Description", "Name", "Url" },
                values: new object[] { 10, "This is a nice photo", "My test photo", "www.google.com" });
        }
    }
}

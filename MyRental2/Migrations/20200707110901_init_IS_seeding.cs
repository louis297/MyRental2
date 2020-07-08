using Microsoft.EntityFrameworkCore.Migrations;

namespace MyRental2.Migrations
{
    public partial class init_IS_seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NickName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4e4e2e0a-be6b-46d5-b723-2eed64d15d59", "8ecf9c8f-0899-4521-a025-69647767ada2", "MyRentalRole", "root", "ROOT" },
                    { "da7fe3fc-b439-4416-969d-afc8ddb558c1", "64793468-47e6-40c3-a29e-3456351f2148", "MyRentalRole", "admin", "ADMIN" },
                    { "ac9a240d-b711-4d2e-8513-b99538488278", "0c38915b-8384-4570-93e7-5b3715bc3f52", "MyRentalRole", "VIP", "VIP" },
                    { "31f5c678-829a-499f-86bb-72c3a65f7536", "967fcdde-3476-4582-8c6a-748d8ba48b1e", "MyRentalRole", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NickName", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4e4e2e0a-be6b-46d5-b723-2eed64d15d59", 0, "2cfb8efc-0684-4ff7-a585-b7d29942fe4e", "admin@x.com", true, "Admin", "Admin", false, null, "louis", "ADMIN@X.COM", "ADMIN@TEST.COM", "AQAAAAEAACcQAAAAENSJOE3O8hyyShlryE81MkCVAsnl5lkRvkk601zN4NfBdaa2Ywj9ZtzzjwKJXCAPGg==", null, false, "", false, "admin@test.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "4e4e2e0a-be6b-46d5-b723-2eed64d15d59", "4e4e2e0a-be6b-46d5-b723-2eed64d15d59" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31f5c678-829a-499f-86bb-72c3a65f7536");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac9a240d-b711-4d2e-8513-b99538488278");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da7fe3fc-b439-4416-969d-afc8ddb558c1");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4e4e2e0a-be6b-46d5-b723-2eed64d15d59", "4e4e2e0a-be6b-46d5-b723-2eed64d15d59" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4e4e2e0a-be6b-46d5-b723-2eed64d15d59");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e4e2e0a-be6b-46d5-b723-2eed64d15d59");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NickName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");
        }
    }
}

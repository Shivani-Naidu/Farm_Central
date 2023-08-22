using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG7311_POE.Data.Migrations
{
    public partial class MAddedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1", "c7e03f3d-3265-48c1-9b1e-4a2428ea3b4f", "Manager", "MANAGER" },
                    { "2", "e2da6376-1ec8-4ad8-b665-f5e29847a5bc", "Employee", "EMPLOYEE" },
                    { "3", "b5f789d2-664a-4466-86ea-41cca1a05297", "Farmer", "FARMER" },
                    { "4", "465d23ac-1bfd-4ee9-a8ac-ba9472306139", "Customer", "CUSTOMER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2", 0, "6007e54f-2672-46c4-8bb7-99893299c046", "employee1@gmail.com", false, false, null, "EMPLOYEE1@GMAIL.COM", "EMPLOYEE1", "AQAAAAEAACcQAAAAENnfifEep/A4g6GA2ViBSruRLrphTZ1RIXqtfbVXLLH3jDpI8cC35dCwbKToPWdQWA==", null, false, "c44b85ab-45a1-4aca-b7e7-b09986411b47", false, "Employee1" },
                    { "3", 0, "eb5f0f0f-7b1e-4f10-aa82-c40057876bb9", "farmer1@gmail.com", false, false, null, "FARMER1@GMAIL.COM", "FARMER1", "AQAAAAEAACcQAAAAEBzJaNMXeBYahLZ+qp0f8QDNHLN43fw8Pl+gqgnwjtRgBZCt8ae5KbH4pTmsmM3MKA==", null, false, "a2859adf-cf29-42e8-b496-c9f5981559b0", false, "Farmer1" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2", "2" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3", "3" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");
        }
    }
}

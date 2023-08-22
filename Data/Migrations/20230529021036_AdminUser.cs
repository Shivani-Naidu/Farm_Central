using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG7311_POE.Data.Migrations
{
    public partial class AdminUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "0f04af19-0973-477c-8be3-73c829483872");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "54acff12-76bf-48fd-9262-658eb1a264db");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "b5f2016f-efb2-479e-b62f-e5666aa4fe60");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "cf51fb41-9452-4ea0-b469-c578eb8e04c7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9ab15f93-46da-4e6f-9676-76c5d7eb72c3", "AQAAAAEAACcQAAAAEGOYUkjO8GnVFdU0rHYroHzt7ZaibuhByPNH/w6p3BaRgHr+Mo7JQJBqcgjR64EOFQ==", "e839e992-f2b8-4382-a44e-4060011251c3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d6f2d03c-75bb-40e7-844c-04625a1a4e31", "AQAAAAEAACcQAAAAEC2PQvSdBq7z++Bx/rCRMqTd672/m+FLyUvU31mhZ8fmSp7Kt23Zt2gNovB/kInEFA==", "87a6046d-4d33-4bf8-bf3c-3073d1e9e7a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f93a2f42-6fba-4edc-a71c-deaeab392804", "AQAAAAEAACcQAAAAEGZI/CgwHCdFgCW4j04RrhMvKmvEOaNVzQorLEPFEHVF9gxhcVn0rPpsKZz+RQAFKA==", "0b4dcd47-aa66-4c02-9daa-a81bf7cadeba" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "e847fc76-d601-4208-a8ee-d66f8adbbea5", "admin1@gmail.com", false, false, null, "ADMIN1@GMAIL.COM", "ADMIN1", "AQAAAAEAACcQAAAAEGcqBGuHH8mz04yYQJMwPIAomaVW5kIIpcr+XPqD8JcGJenEdCb6EPe4o6mB8juQHA==", null, false, "f0f101d1-a47d-4bce-9d2e-cf38a8c7c019", false, "Admin1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "bd9a75c6-4137-430d-bf5a-84b678684969");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "5ae377c1-9a6c-476a-a114-1e7ca4a587fc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "963d4197-6f26-4b31-8704-f4601123d5d4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "fcf67cd1-1475-48ed-a20b-091d7e29d302");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b392f550-027c-4618-a7fe-d53c60af0835", "AQAAAAEAACcQAAAAEII3ZoofkCwppyZMPUPTclHJpfHt2qqXVUyJQAYEaiDn61R+Rw84koedxdPwBPwKbw==", "6c1da1ec-c582-4ad8-bc50-2fbf1f64b2fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "daea6f24-2acf-4bb9-aab1-2aab9922417e", "AQAAAAEAACcQAAAAEELkQD0rsIVbO2+jXJqtdV2OpKYvA9RnrWUAQ2mBa9c/9akJUCJD88BlpopMKNeMgQ==", "38c71e0d-77d7-4240-a45c-2feb0042065e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bd6d1c59-f901-4b49-9f7c-f6c037ce42a9", "AQAAAAEAACcQAAAAEI9TEoaURDILo+hgS1fFdoLDtR2xd2hyzG+QsZ+DcSf4sp6DT894OrSjYQaHocxokA==", "e181d663-dbfd-494c-a1f8-174643926918" });
        }
    }
}

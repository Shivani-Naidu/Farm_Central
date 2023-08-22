using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG7311_POE.Data.Migrations
{
    public partial class ProductPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                type: "decimal(10,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "cd024f18-d575-4c27-ab3d-ffff3dc1bc3b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "cdc50002-2860-4c8f-8651-254a8cd00a02");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "cfb059a2-1089-4a69-8891-897970d378f1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "ab966a23-3ce1-4d18-9b1e-824fac231f5b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "28174115-f8f2-4ffe-9139-cb7737dbfda3", "AQAAAAEAACcQAAAAEBrfjbKSPcsVMRVa/2fUj2i3en/WrJjMaMX3uVElkbK7Xp8blw3DXON2AIfZ6x0Ehg==", "6e9c19ad-0466-44e3-a009-c636c0c7c715" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a89c1c7-d007-4ad0-ab88-d46d666d1ea5", "AQAAAAEAACcQAAAAEKKu0mhQCjNDfiVq2RB6od9xRe1Zoh6t4EPvfUo885Q3IxtZlncthMCZJ91OId2JZQ==", "16c019e4-886b-4e29-a78c-6404ec5cf827" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3c52b052-dc3f-4cbc-8461-0220f2001f90", "AQAAAAEAACcQAAAAEJ+Mm/Lzhty4Wg0g/8ro7v/8wrVTtkZbBhG5LleKzBRA1FrtmNlvtvu7fvOwOEZLJQ==", "424a3b94-4ff8-49ab-bd6a-908bf0d020e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c9ea8d0-d89b-4fd6-a795-309c4a22c615", "AQAAAAEAACcQAAAAEBTcCYk/MBEDThuYJjDVQNR1toYDwnPpoffWbR8QMIcbIaAZQ9Tx/s2bwabHpWopgw==", "35a8cf61-eae0-49ad-92af-5909be2b03ae" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Product",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(10,2)");

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
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e847fc76-d601-4208-a8ee-d66f8adbbea5", "AQAAAAEAACcQAAAAEGcqBGuHH8mz04yYQJMwPIAomaVW5kIIpcr+XPqD8JcGJenEdCb6EPe4o6mB8juQHA==", "f0f101d1-a47d-4bce-9d2e-cf38a8c7c019" });

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
        }
    }
}

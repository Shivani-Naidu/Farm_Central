using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG7311_POE.Data.Migrations
{
    public partial class ApplicationComplete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "449dd472-5110-48fc-a20e-452eea0e5a66");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1a7118fe-2280-4d1c-9a2a-402d173a4780");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "c973e121-7b0d-4174-9972-9948b3af4d87");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "29f63f69-30e4-4392-8e92-e36ef1779857");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1eda4fcb-52ff-45fc-87c0-6bf01ebe23d5", "AQAAAAEAACcQAAAAEFtGwYDmgYGHcbEG1aUZ5Db1rYnvqvHivAKS62YzhF8ClrskeY3s8p+cHSsiy5coMw==", "44d1343d-5297-4872-9d9b-4237416800a2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f564d61-1b7c-4663-8aed-48858f629027", "AQAAAAEAACcQAAAAEHUDVvJ0kZ11mb44Q290DFA+mtGqnG8RkXXDAfE2p+YPXc+9uHqS8Ues+nvt0Lo1rg==", "e8ff595f-6791-4a24-9333-69a6d7f89236" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "680d57e1-42f3-4e2b-ae58-ccbd48202636", "AQAAAAEAACcQAAAAEJ7Rj6WzWS6a89SFzmbDtgvRF2UzkUOXt69Utmd46k5EljczFT8urm2RjixPumtgTQ==", "33b51aa4-1f64-4f1d-9069-806d11cdc4e1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "401219e5-eade-4d0d-b7a9-58307c6c7bec", "AQAAAAEAACcQAAAAEDSFsnUwkNscCc2JGXykoxI5vC073O75kzZFgZKuDgHtCREtezmIUo3a6kCnNk+M8A==", "485cde99-202b-41f8-b65e-d93f32d9b837" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}

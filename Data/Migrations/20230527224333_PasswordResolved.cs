using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG7311_POE.Data.Migrations
{
    public partial class PasswordResolved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "d7104322-1f69-431d-8b49-0381bfcc18ef");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "2b9afe63-e87c-484b-8179-406a9e40b0ae");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "6d2bc1c1-d7b6-42d7-8275-919e8f8e17a9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "59020f47-f12b-480c-b321-a7d332f3e0ff");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6358c393-3105-4b98-a488-78e4f91711d7", "AQAAAAEAACcQAAAAELSoff0nfgyKkYhRQM5pI09fKlRCMNNXEsWnsXgE8XFXjvhqGdyINpqjLqWDx61SxQ==", "c5a2940e-c65c-4d37-8f40-0c89c428b394" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2862af12-3077-4808-9757-fd552ed0489b", "AQAAAAEAACcQAAAAEE1/oJI5d1OLCppCaCXeyS21bUBatTxIk9zykPGhpfQXKzPM78Wu9hIOo+aQZ+b8yQ==", "fde460fe-f3e7-4cf2-b860-db7dcb784dd0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "f8a2ba7f-a70d-445b-aa8a-9fa27b011453");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "040b4a1d-0068-468d-b19b-f9acb04b7d1e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "53f5b5b3-f522-4345-a837-ebaf7d867a64");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "12a4cbe9-9f12-4b3a-ad15-ff8e27822cc9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2dc3aa0-c0ed-42f6-803e-74cb06b48e7d", "AQAAAAEAACcQAAAAEHmdo0oKZuZGt6tcJNHdvsAMZKzxJQbUjViB4+yELfdMXSVOhru5ZtgEopXkzwroQw==", "b92e7d54-1b4f-43ad-b718-f6e12df35f1c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2f8ddc4-29f3-4694-b9b1-fa27f14c2011", "AQAAAAEAACcQAAAAEJQOayyHguEC3WrzwMhjSu8vVw8PjdUBCeihof3oMG+5rMI8FKcHZAv9bfA/yObhNA==", "9291145a-4722-4039-a377-1caa80b64159" });
        }
    }
}

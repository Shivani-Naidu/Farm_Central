using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG7311_POE.Data.Migrations
{
    public partial class FinalTesting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "77bfa448-ad66-47b4-8e15-5c37fcd6f60c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "586fd05f-caf7-4057-ab79-1869d212f6d6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "917ae41c-04df-483e-85bb-e266aab463b0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "55845a8f-7a57-4258-a399-7d10c4d3236b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a0bedbf-16a7-42a8-8077-67afb4bc68b0", "AQAAAAEAACcQAAAAEH1IfdcBK5cQkMIJSyL7bYcLFZH6SjmOQ9kJUbg9Qj/L0x2vL2Mn9aHp4RVzkDMyYA==", "8131efca-511c-4945-8a11-5ae6b37f7152" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "602d8c42-535c-4795-a7a4-b49d04a703c9", "AQAAAAEAACcQAAAAEOqqoAzt84H0Y0oQS4gqB2aYIp1IwikNS/Sl1RCaEL1ZlkY3KmF9Adtpww0CFAyoYw==", "a7ea1502-9f4a-4714-8cff-ec6d3e2d1485" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG7311_POE.Data.Migrations
{
    public partial class RegisterFarmer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2ed2c1bc-a7fc-47bf-b147-ea669941b3fc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "d56abb0a-906e-4d16-b728-14780cb8b46b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "072d070a-a97d-4d3c-9fe8-8f922f9b701f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "aec45fb0-5db0-4558-bc2a-377c62d96547");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bedd87c0-fbd1-44e6-a7e5-d0f336630023", "AQAAAAEAACcQAAAAEACI2rh1c+8m1BSxWjevFLKkHug+56AxtpFEp+P6KHzKgHlfhiXimy80Hd6ulkuEKA==", "fb87782f-310b-48c8-a943-12b27622f18e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c03ce7b4-1564-44e5-bc96-84e4d2ea4cef", "AQAAAAEAACcQAAAAEESQCciN7tlOAwQSV7c4Mtdy5FrCmBFS1oJtLdrbek+nQIlOWQxVq8VFfi4ggOmHHw==", "de66ee3c-7d01-47ed-bfff-b6ac181e8925" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG7311_POE.Data.Migrations
{
    public partial class Farmer2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4", "3" });

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3", "4" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3", "4" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "4022535b-6a7d-4281-9bc6-ced5ba424e10");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "225a81cd-68a2-4b48-81e7-10d1c7433172");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "613df96f-9a3b-4caa-8ea0-35229934424e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "fff1f9e7-0248-4cb0-88a4-5403283f4c66");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4", "3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d2374a1-ea1b-4915-ab15-dd02ad3fc673", "AQAAAAEAACcQAAAAEORmg/U3R5xCDaSvGEk/lbnR5YkTr/itgJkqljArjt8oe/Ut5B5w9jCm9E/qQi2pTw==", "c3f3f02a-e947-40b2-a059-a31d55d4fd63" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "010aeb1f-9bd5-405b-9325-179cea8171fa", "AQAAAAEAACcQAAAAEC+FbSLL4rQguubOpV32o5AXEFxaoLTkN7MCB5nISVwxzV3c2FyDQlaZyul5eQyNVw==", "19d6d9ea-0124-411b-b739-6d32f7badfbd" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48b1ee6d-ea93-41ce-a983-a21fba29c829", "AQAAAAEAACcQAAAAEMlqxfG4Ijcyo+W/hS1KTs6BP4WcSMdyUu7YC/YcsjqjnbTfUAND/GNiCKJSajmvPw==", "907c6e43-369c-4a68-ac05-8cc6cae378c7" });
        }
    }
}

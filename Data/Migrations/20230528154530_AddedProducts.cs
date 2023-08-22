using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG7311_POE.Data.Migrations
{
    public partial class AddedProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4022535b-6a7d-4281-9bc6-ced5ba424e10", "Admin", "ADMIN" });

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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4", 0, "48b1ee6d-ea93-41ce-a983-a21fba29c829", "farmer2@gmail.com", false, false, null, "FARMER2@GMAIL.COM", "FARMER2", "AQAAAAEAACcQAAAAEMlqxfG4Ijcyo+W/hS1KTs6BP4WcSMdyUu7YC/YcsjqjnbTfUAND/GNiCKJSajmvPw==", null, false, "907c6e43-369c-4a68-ac05-8cc6cae378c7", false, "Farmer2" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "ProductDesc", "ProductName" },
                values: new object[] { "Freshly Harvested Spring Onions", "Spring Onions" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "DateAdded", "FarmerID", "Price", "ProductCategory", "ProductDesc", "ProductImage", "ProductName", "Quantity" },
                values: new object[,]
                {
                    { 2, new DateTime(2023, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 20m, "Fruit", "Freshly Harvested Strawberries", "https://www.dispatch.com/gcdn/presto/2022/05/10/NCOD/0a1efdfc-bc59-40bb-9007-f6a875ae1b0a-strawberries_in_rows.JPG", "Strawberries", 30 },
                    { 3, new DateTime(2023, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 25m, "Fruit", "Freshly Harvested Pineapples", "https://media6.ppl-media.com/mediafiles/blogs/pineapple_6439817058.jpg", "Pineapples", 20 },
                    { 4, new DateTime(2023, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 10m, "Fruit", "Freshly Harvested Peaches", "https://extension.usu.edu/nutrition/images/peaches.png", "Peaches", 20 },
                    { 5, new DateTime(2023, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 15m, "Vegetable", "Freshly Harvested Carrots", "https://www.almanac.com/sites/default/files/styles/or/public/image_nodes/carrots-table_popidar-ss.jpg?itok=-6KDefXK", "Carrots", 50 },
                    { 6, new DateTime(2023, 5, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "4", 25m, "Flowers and Plants", "Fresh Sunflowers", "https://cdn.wikifarmer.com/wp-content/uploads/2022/06/Sunflower-History-Uses-and-Plant-information.jpg", "Sunflowers", 35 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4", "3" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d7104322-1f69-431d-8b49-0381bfcc18ef", "Manager", "MANAGER" });

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

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1,
                columns: new[] { "ProductDesc", "ProductName" },
                values: new object[] { "Freshly Harvested Green Onions", "Green Onions" });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG7311_POE.Data.Migrations
{
    public partial class Products2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1000,
                column: "DateAdded",
                value: new DateTime(2023, 5, 26, 5, 28, 41, 336, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "DateAdded", "FarmerID", "ProductDesc", "ProductImage", "ProductName", "Quantity" },
                values: new object[] { 1001, new DateTime(2023, 5, 26, 5, 28, 41, 338, DateTimeKind.Local).AddTicks(9346), "5654fdcf-3a04-4136-9e32-8795c81d57c2", "Fresh Strawberries", "https://www.allrecipes.com/thmb/1c99SWam7_FM6vUzpDDzIKffMR4=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/ALR-strawberry-fruit-or-vegetable-f6dd901427714e46af2d706a57b9016f.jpg", "Strawberries", 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1001);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1000,
                column: "DateAdded",
                value: new DateTime(2023, 5, 26, 5, 2, 12, 249, DateTimeKind.Local).AddTicks(3298));
        }
    }
}

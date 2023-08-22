using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG7311_POE.Data.Migrations
{
    public partial class Category : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1001);

            migrationBuilder.AddColumn<string>(
                name: "ProductCategory",
                table: "Product",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductCategory",
                table: "Product");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "DateAdded", "FarmerID", "ProductDesc", "ProductImage", "ProductName", "Quantity" },
                values: new object[] { 1000, new DateTime(2023, 5, 26, 5, 28, 41, 336, DateTimeKind.Local).AddTicks(1047), "e2f9c8ae-52ef-450d-9fa5-6da60f535f50", "Fresh Green Onions", "https://www.eatingwell.com/thmb/g3atnQeaOhAXnXfOCnkMuo5K-9w=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/chives-vs-green-onions-55bf8002ee1f4bd384a8502f6bae5476.jpg", "Green Onions", 2 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "DateAdded", "FarmerID", "ProductDesc", "ProductImage", "ProductName", "Quantity" },
                values: new object[] { 1001, new DateTime(2023, 5, 26, 5, 28, 41, 338, DateTimeKind.Local).AddTicks(9346), "5654fdcf-3a04-4136-9e32-8795c81d57c2", "Fresh Strawberries", "https://www.allrecipes.com/thmb/1c99SWam7_FM6vUzpDDzIKffMR4=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/ALR-strawberry-fruit-or-vegetable-f6dd901427714e46af2d706a57b9016f.jpg", "Strawberries", 3 });
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG7311_POE.Data.Migrations
{
    public partial class Products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductDesc = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FarmerID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductImage = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductID);
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "DateAdded", "FarmerID", "ProductDesc", "ProductImage", "ProductName", "Quantity" },
                values: new object[] { 1000, new DateTime(2023, 5, 26, 5, 2, 12, 249, DateTimeKind.Local).AddTicks(3298), "e2f9c8ae-52ef-450d-9fa5-6da60f535f50", "Fresh Green Onions", "https://www.eatingwell.com/thmb/g3atnQeaOhAXnXfOCnkMuo5K-9w=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/chives-vs-green-onions-55bf8002ee1f4bd384a8502f6bae5476.jpg", "Green Onions", 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG7311_POE.Data.Migrations
{
    public partial class TestPicture : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c8311b59-4153-40e7-a9ca-5df00e6e9cbe");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "1c168d80-e596-4661-94b9-7594cfac1078");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "708adf48-d3a6-4ac8-a5f0-3a4c25cc3a6e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "b21737ae-756d-4d6f-b354-f8919940de33");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c075cc7c-3036-4c43-a588-0d284c615f01", "AQAAAAEAACcQAAAAEPXXeoA/2k9LmszPszzPB5N+3eETPmqzvjTm5ZvDK9GgEH1HLSVD/WSZM47Fijtnow==", "2615869d-9e31-467a-a001-fda2316585ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "63c8aae2-817c-46ea-960d-d382366ea840", "AQAAAAEAACcQAAAAEIjQnLu/UPGiskebtVsHM5vPX9FNHQp2Buc4oFT9ODvRrNSxcWQ1hQ1nG8EYVN5XTg==", "5ad25d8d-03f3-4ace-8b98-fb77e1fd1d3b" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "DateAdded", "FarmerID", "Price", "ProductCategory", "ProductDesc", "ProductImage", "ProductName", "Quantity" },
                values: new object[] { 1, new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "3", 30m, "Vegetable", "Freshly Harvested Green Onions", "https://www.foodandwine.com/thmb/mlUUeD3gpRZQq2qUs8nead6QAYY=/1500x0/filters:no_upscale():max_bytes(150000):strip_icc()/The-Difference-Between-Green-Onions-FT-3-BLOG0622-3e3086b7871d44309f4d64dfe8536e00.jpg", "Green Onions", 15 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c7e03f3d-3265-48c1-9b1e-4a2428ea3b4f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "e2da6376-1ec8-4ad8-b665-f5e29847a5bc");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3",
                column: "ConcurrencyStamp",
                value: "b5f789d2-664a-4466-86ea-41cca1a05297");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4",
                column: "ConcurrencyStamp",
                value: "465d23ac-1bfd-4ee9-a8ac-ba9472306139");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6007e54f-2672-46c4-8bb7-99893299c046", "AQAAAAEAACcQAAAAENnfifEep/A4g6GA2ViBSruRLrphTZ1RIXqtfbVXLLH3jDpI8cC35dCwbKToPWdQWA==", "c44b85ab-45a1-4aca-b7e7-b09986411b47" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb5f0f0f-7b1e-4f10-aa82-c40057876bb9", "AQAAAAEAACcQAAAAEBzJaNMXeBYahLZ+qp0f8QDNHLN43fw8Pl+gqgnwjtRgBZCt8ae5KbH4pTmsmM3MKA==", "a2859adf-cf29-42e8-b496-c9f5981559b0" });
        }
    }
}

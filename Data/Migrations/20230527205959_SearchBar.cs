using Microsoft.EntityFrameworkCore.Migrations;

namespace ST10084788_PROG7311_POE.Data.Migrations
{
    public partial class SearchBar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductCategory",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ProductCategory",
                table: "Product",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
        }
    }
}

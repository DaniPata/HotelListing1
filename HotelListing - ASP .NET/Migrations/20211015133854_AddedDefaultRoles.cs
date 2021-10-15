using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing___ASP_.NET.Migrations
{
    public partial class AddedDefaultRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff2c990c-6b59-4c04-9950-f3ad26d6f81f", "42a63cd0-b8aa-47dc-9da0-bd4337d1ad4b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "99c26353-57f8-44ed-9344-420498b27d14", "e5825cb0-71d6-4d3c-9cd4-feabee501e99", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "99c26353-57f8-44ed-9344-420498b27d14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff2c990c-6b59-4c04-9950-f3ad26d6f81f");
        }
    }
}

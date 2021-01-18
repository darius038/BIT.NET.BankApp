using Microsoft.EntityFrameworkCore.Migrations;

namespace BIT.NET.BankApp.Data.Migrations
{
    public partial class roles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb82e71d-a71d-4f19-b830-1d255fa9f641", "1294e2d7-40df-4933-9874-7498545de93f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "318ce497-53d3-48dd-aa43-f32b58afee09", "13219c62-fab5-41ce-a175-4d74575300f5", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "318ce497-53d3-48dd-aa43-f32b58afee09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb82e71d-a71d-4f19-b830-1d255fa9f641");
        }
    }
}

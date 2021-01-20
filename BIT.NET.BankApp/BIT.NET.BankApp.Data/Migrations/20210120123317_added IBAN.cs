using Microsoft.EntityFrameworkCore.Migrations;

namespace BIT.NET.BankApp.Data.Migrations
{
    public partial class addedIBAN : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "318ce497-53d3-48dd-aa43-f32b58afee09");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb82e71d-a71d-4f19-b830-1d255fa9f641");

            migrationBuilder.AddColumn<string>(
                name: "IBAN",
                table: "Accounts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2da521f9-340b-4f5e-8a56-203b0dc67a59", "d50db15e-a973-4d7d-8ccc-8b38f4111aa6", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f7e0edad-1ee2-45c5-a427-b334be99605a", "7e6a7de1-8243-491d-a3b6-46de8e481760", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2da521f9-340b-4f5e-8a56-203b0dc67a59");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f7e0edad-1ee2-45c5-a427-b334be99605a");

            migrationBuilder.DropColumn(
                name: "IBAN",
                table: "Accounts");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fb82e71d-a71d-4f19-b830-1d255fa9f641", "1294e2d7-40df-4933-9874-7498545de93f", "Customer", "CUSTOMER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "318ce497-53d3-48dd-aa43-f32b58afee09", "13219c62-fab5-41ce-a175-4d74575300f5", "Administrator", "ADMINISTRATOR" });
        }
    }
}

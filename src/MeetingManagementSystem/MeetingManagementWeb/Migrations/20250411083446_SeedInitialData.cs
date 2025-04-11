using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MeetingManagementWeb.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Corporate_Customer_Tbl",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0267480b-8765-4347-b5d1-18b8d18358ae"), "Global Corp" },
                    { new Guid("859f0788-3d16-46d3-9421-44802b1e0259"), "XYZ Enterprises" },
                    { new Guid("b2ef4b41-a7ef-4f01-985e-a805a2d835cf"), "ABC Technologies" }
                });

            migrationBuilder.InsertData(
                table: "Individual_Customer_Tbl",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("39ea6912-30dd-4626-8426-a8fa39256a2c"), "John Doe" },
                    { new Guid("7a5c3041-7e48-40b0-b475-1cdf4bcfafa1"), "Jane Smith" },
                    { new Guid("923829fa-54ca-40aa-a0c1-4f121f7a7338"), "Michael Johnson" }
                });

            migrationBuilder.InsertData(
                table: "Products_Service_Tbl",
                columns: new[] { "Id", "Name", "Unit" },
                values: new object[,]
                {
                    { new Guid("050f85ac-aa29-429a-a335-653cd09a196b"), "Consulting", "Hour" },
                    { new Guid("cd7b345b-3037-4216-8065-9f8d69966ae1"), "Hardware Device", "Unit" },
                    { new Guid("ce9466d9-8491-4408-aeeb-a4880d2063e0"), "Software License", "Piece" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Corporate_Customer_Tbl",
                keyColumn: "Id",
                keyValue: new Guid("0267480b-8765-4347-b5d1-18b8d18358ae"));

            migrationBuilder.DeleteData(
                table: "Corporate_Customer_Tbl",
                keyColumn: "Id",
                keyValue: new Guid("859f0788-3d16-46d3-9421-44802b1e0259"));

            migrationBuilder.DeleteData(
                table: "Corporate_Customer_Tbl",
                keyColumn: "Id",
                keyValue: new Guid("b2ef4b41-a7ef-4f01-985e-a805a2d835cf"));

            migrationBuilder.DeleteData(
                table: "Individual_Customer_Tbl",
                keyColumn: "Id",
                keyValue: new Guid("39ea6912-30dd-4626-8426-a8fa39256a2c"));

            migrationBuilder.DeleteData(
                table: "Individual_Customer_Tbl",
                keyColumn: "Id",
                keyValue: new Guid("7a5c3041-7e48-40b0-b475-1cdf4bcfafa1"));

            migrationBuilder.DeleteData(
                table: "Individual_Customer_Tbl",
                keyColumn: "Id",
                keyValue: new Guid("923829fa-54ca-40aa-a0c1-4f121f7a7338"));

            migrationBuilder.DeleteData(
                table: "Products_Service_Tbl",
                keyColumn: "Id",
                keyValue: new Guid("050f85ac-aa29-429a-a335-653cd09a196b"));

            migrationBuilder.DeleteData(
                table: "Products_Service_Tbl",
                keyColumn: "Id",
                keyValue: new Guid("cd7b345b-3037-4216-8065-9f8d69966ae1"));

            migrationBuilder.DeleteData(
                table: "Products_Service_Tbl",
                keyColumn: "Id",
                keyValue: new Guid("ce9466d9-8491-4408-aeeb-a4880d2063e0"));
        }
    }
}

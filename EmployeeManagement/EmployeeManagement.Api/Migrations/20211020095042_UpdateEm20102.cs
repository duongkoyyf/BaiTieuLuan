using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class UpdateEm20102 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.CreateTable(
                name: "NhomHangs",
                columns: table => new
                {
                    NhomHangId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NhomHangName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhomHangs", x => x.NhomHangId);
                });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "Gia", "MaNhomHang", "SoLuongMau", "Ten" },
                values: new object[] { 8059000f, 1, 1, "Nike Air Zoom Alphafly NEXT%" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "Gia", "MaNhomHang", "SoLuongMau", "Ten" },
                values: new object[] { 8059000f, 2, 1, "Nike Air Zoom Alphafly NEXT%" });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "Gia", "MaNhomHang", "SoLuongMau", "Ten" },
                values: new object[] { 6609000f, 1, 1, "Nike ZoomX Vaporfly Next% 2" });

            migrationBuilder.InsertData(
                table: "NhomHangs",
                columns: new[] { "NhomHangId", "NhomHangName" },
                values: new object[,]
                {
                    { 1, "Men's Road Racing Shoes" },
                    { 2, "Women's Racing Shoe" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NhomHangs");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                columns: new[] { "Gia", "MaNhomHang", "SoLuongMau", "Ten" },
                values: new object[] { 0f, 0, 0, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                columns: new[] { "Gia", "MaNhomHang", "SoLuongMau", "Ten" },
                values: new object[] { 0f, 0, 0, null });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                columns: new[] { "Gia", "MaNhomHang", "SoLuongMau", "Ten" },
                values: new object[] { 0f, 0, 0, null });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBrith", "DepartmentId", "Email", "FirstName", "Gender", "Gia", "LastName", "MaNhomHang", "PhotoPath", "SoLuongMau", "Ten" },
                values: new object[] { 4, new DateTime(1982, 9, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "sara@pragimtech.com", "Sara", 1, 0f, "Longway", 0, "images/sara.png", 0, null });
        }
    }
}

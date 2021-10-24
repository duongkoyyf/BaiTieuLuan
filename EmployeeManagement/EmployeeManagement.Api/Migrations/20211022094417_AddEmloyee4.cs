using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class AddEmloyee4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "DateOfBrith", "DepartmentId", "Email", "FirstName", "Gender", "Gia", "LastName", "NhomHangId", "PhotoPath", "SoLuongMau", "Ten" },
                values: new object[] { 4, new DateTime(1979, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "mary@pragimtech.com", "Mary", 1, 6609000f, "Smith", 2, "images/zoomx-vaporfly-next-2-road-racing-shoes-fG92S8.jpg", 1, "Nike ZoomX Vaporfly Next% 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);
        }
    }
}

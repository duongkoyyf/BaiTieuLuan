using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class UpdateEm20103 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "PhotoPath",
                value: "images/air-zoom-alphafly-next-road-racing-shoes-13jzhr.jpg");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "PhotoPath",
                value: "images/air-zoom-alphafly-next-racing-shoe-Wd4lk6.jpg");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "PhotoPath",
                value: "images/zoomx-vaporfly-next-2-road-racing-shoes-D4ntS0.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1,
                column: "PhotoPath",
                value: "images/john.png");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2,
                column: "PhotoPath",
                value: "images/sam.jpg");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3,
                column: "PhotoPath",
                value: "images/mary.png");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeManagement.Api.Migrations
{
    public partial class UpdateMaNhomHang : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MaNhomHang",
                table: "Employees",
                newName: "NhomHangId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_NhomHangId",
                table: "Employees",
                column: "NhomHangId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_NhomHangs_NhomHangId",
                table: "Employees",
                column: "NhomHangId",
                principalTable: "NhomHangs",
                principalColumn: "NhomHangId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_NhomHangs_NhomHangId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_NhomHangId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "NhomHangId",
                table: "Employees",
                newName: "MaNhomHang");
        }
    }
}

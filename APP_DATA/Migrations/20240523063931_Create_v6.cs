using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_DATA.Migrations
{
    public partial class Create_v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillStatusHistories_Employees_EmployeeID",
                table: "BillStatusHistories");

            migrationBuilder.DropIndex(
                name: "IX_BillStatusHistories_EmployeeID",
                table: "BillStatusHistories");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "BillStatusHistories");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "EmployeeID",
                table: "BillStatusHistories",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_BillStatusHistories_EmployeeID",
                table: "BillStatusHistories",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_BillStatusHistories_Employees_EmployeeID",
                table: "BillStatusHistories",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_DATA.Migrations
{
    public partial class Create_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_ShoesDetails_ShoesDetailsID",
                table: "BillDetails");

            migrationBuilder.DropIndex(
                name: "IX_BillDetails_ShoesDetailsID",
                table: "BillDetails");

            migrationBuilder.DropColumn(
                name: "ShoesDetailsID",
                table: "BillDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "ShoesDetails_SizeID",
                table: "ShoesDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShoesDetails_SizeID",
                table: "ShoesDetails");

            migrationBuilder.AddColumn<Guid>(
                name: "ShoesDetailsID",
                table: "BillDetails",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_ShoesDetailsID",
                table: "BillDetails",
                column: "ShoesDetailsID");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_ShoesDetails_ShoesDetailsID",
                table: "BillDetails",
                column: "ShoesDetailsID",
                principalTable: "ShoesDetails",
                principalColumn: "ShoesDetailsID");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_DATA.Migrations
{
    public partial class Create_v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bills_Addresses_AddressID",
                table: "Bills");

            migrationBuilder.DropIndex(
                name: "IX_Bills_AddressID",
                table: "Bills");

            migrationBuilder.DropColumn(
                name: "AddressID",
                table: "Bills");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "AddressID",
                table: "Bills",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Bills_AddressID",
                table: "Bills",
                column: "AddressID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bills_Addresses_AddressID",
                table: "Bills",
                column: "AddressID",
                principalTable: "Addresses",
                principalColumn: "AddressID");
        }
    }
}

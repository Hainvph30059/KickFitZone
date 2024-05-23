using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_DATA.Migrations
{
    public partial class Create_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoesDetails_Sizes_SizeID",
                table: "ShoesDetails");

            migrationBuilder.DropIndex(
                name: "IX_ShoesDetails_SizeID",
                table: "ShoesDetails");

            migrationBuilder.DropColumn(
                name: "SizeID",
                table: "ShoesDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "SizeID",
                table: "ShoesDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_ShoesDetails_SizeID",
                table: "ShoesDetails",
                column: "SizeID");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoesDetails_Sizes_SizeID",
                table: "ShoesDetails",
                column: "SizeID",
                principalTable: "Sizes",
                principalColumn: "SizeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

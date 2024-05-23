using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_DATA.Migrations
{
    public partial class Create_v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BillDetails_ShoesDetails_Sizes_ShoesDetails_SizeID",
                table: "BillDetails");

            migrationBuilder.DropIndex(
                name: "IX_BillDetails_ShoesDetails_SizeID",
                table: "BillDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BillDetails_ShoesDetails_SizeID",
                table: "BillDetails",
                column: "ShoesDetails_SizeID");

            migrationBuilder.AddForeignKey(
                name: "FK_BillDetails_ShoesDetails_Sizes_ShoesDetails_SizeID",
                table: "BillDetails",
                column: "ShoesDetails_SizeID",
                principalTable: "ShoesDetails_Sizes",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APP_DATA.Migrations
{
    public partial class remove_colunm_priceImport_from_table_shoeDetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImportPrice",
                table: "ShoesDetails");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ImportPrice",
                table: "ShoesDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}

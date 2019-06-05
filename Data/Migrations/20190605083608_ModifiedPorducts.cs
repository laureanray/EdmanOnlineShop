using Microsoft.EntityFrameworkCore.Migrations;

namespace EdmanOnlineShop.Data.Migrations
{
    public partial class ModifiedPorducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Products",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Products");
        }
    }
}

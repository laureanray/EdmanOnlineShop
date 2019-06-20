using Microsoft.EntityFrameworkCore.Migrations;

namespace EdmanOnlineShop.Migrations
{
    public partial class asdaosdkaosds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderID",
                table: "Returns",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderID",
                table: "Returns");
        }
    }
}

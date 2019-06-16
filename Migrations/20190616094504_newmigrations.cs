using Microsoft.EntityFrameworkCore.Migrations;

namespace EdmanOnlineShop.Migrations
{
    public partial class newmigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestHeader",
                table: "Requests");

            migrationBuilder.RenameColumn(
                name: "ProductID",
                table: "Requests",
                newName: "CartItemID");

            migrationBuilder.AddColumn<int>(
                name: "RequestStatus",
                table: "Requests",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsRequested",
                table: "CartItems",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestStatus",
                table: "Requests");

            migrationBuilder.DropColumn(
                name: "IsRequested",
                table: "CartItems");

            migrationBuilder.RenameColumn(
                name: "CartItemID",
                table: "Requests",
                newName: "ProductID");

            migrationBuilder.AddColumn<string>(
                name: "RequestHeader",
                table: "Requests",
                nullable: true);
        }
    }
}

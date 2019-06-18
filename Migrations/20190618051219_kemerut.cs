using Microsoft.EntityFrameworkCore.Migrations;

namespace EdmanOnlineShop.Migrations
{
    public partial class kemerut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RequestDetails",
                table: "Requests");

            migrationBuilder.AddColumn<int>(
                name: "ProductID",
                table: "Feedbacks",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Rating",
                table: "Feedbacks",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductID",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Feedbacks");

            migrationBuilder.AddColumn<string>(
                name: "RequestDetails",
                table: "Requests",
                nullable: true);
        }
    }
}

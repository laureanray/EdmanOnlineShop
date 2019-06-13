using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EdmanOnlineShop.Data.Migrations
{
    public partial class newfield : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateDelivered",
                table: "Orders",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateDelivered",
                table: "Orders");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EdmanOnlineShop.Migrations
{
    public partial class ew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Feedbacks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsArchived",
                table: "Feedbacks",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Feedbacks");

            migrationBuilder.DropColumn(
                name: "IsArchived",
                table: "Feedbacks");
        }
    }
}

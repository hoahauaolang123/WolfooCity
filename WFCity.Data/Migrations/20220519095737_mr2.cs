using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WFCity.Data.Migrations
{
    public partial class mr2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "NgayBanVe",
                table: "OrderItems",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayBanVe",
                table: "OrderItems");
        }
    }
}

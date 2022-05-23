using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WFCity.Data.Migrations
{
    public partial class nr : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "NgayBanVe",
                table: "ThongTinVes",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NgayBanVe",
                table: "ThongTinVes");
        }
    }
}

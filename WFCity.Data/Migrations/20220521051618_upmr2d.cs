using Microsoft.EntityFrameworkCore.Migrations;

namespace WFCity.Data.Migrations
{
    public partial class upmr2d : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MaDonHang",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ThuTuDonHang",
                table: "Orders",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaDonHang",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ThuTuDonHang",
                table: "Orders");
        }
    }
}

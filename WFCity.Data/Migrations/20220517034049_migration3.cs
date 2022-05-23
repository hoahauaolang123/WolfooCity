using Microsoft.EntityFrameworkCore.Migrations;

namespace WFCity.Data.Migrations
{
    public partial class migration3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ThuTuVe",
                table: "ThongTinVes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SoLuongDaSuDung",
                table: "MaGiamGias",
                type: "int",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThuTuVe",
                table: "ThongTinVes");

            migrationBuilder.DropColumn(
                name: "SoLuongDaSuDung",
                table: "MaGiamGias");
        }
    }
}

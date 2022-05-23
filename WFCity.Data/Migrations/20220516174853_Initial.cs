using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WFCity.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppConfigs",
                columns: table => new
                {
                    Key = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppConfigs", x => x.Key);
                });

            migrationBuilder.CreateTable(
                name: "LoaiVes",
                columns: table => new
                {
                    LoaiVeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GiaVe = table.Column<double>(type: "float", nullable: false),
                    DaXoa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiVes", x => x.LoaiVeId);
                });

            migrationBuilder.CreateTable(
                name: "MaGiamGias",
                columns: table => new
                {
                    MaGiamGiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMaGiamGia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuongSuDung = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    TyLe = table.Column<int>(type: "int", nullable: true),
                    SoTien = table.Column<int>(type: "int", nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaGiamGias", x => x.MaGiamGiaId);
                });

            migrationBuilder.CreateTable(
                name: "ThongTinVes",
                columns: table => new
                {
                    ThongTinVeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaVe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiVeId = table.Column<int>(type: "int", nullable: true),
                    NgayTaoVe = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayBanVe = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TrangThai = table.Column<int>(type: "int", nullable: true),
                    SoDienThoai = table.Column<int>(type: "int", nullable: true),
                    MaGiamGiaId = table.Column<int>(type: "int", nullable: true),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DaXoa = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongTinVes", x => x.ThongTinVeId);
                    table.ForeignKey(
                        name: "FK_ThongTinVes_LoaiVes_LoaiVeId",
                        column: x => x.LoaiVeId,
                        principalTable: "LoaiVes",
                        principalColumn: "LoaiVeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ThongTinVes_MaGiamGias_MaGiamGiaId",
                        column: x => x.MaGiamGiaId,
                        principalTable: "MaGiamGias",
                        principalColumn: "MaGiamGiaId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinVes_LoaiVeId",
                table: "ThongTinVes",
                column: "LoaiVeId");

            migrationBuilder.CreateIndex(
                name: "IX_ThongTinVes_MaGiamGiaId",
                table: "ThongTinVes",
                column: "MaGiamGiaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppConfigs");

            migrationBuilder.DropTable(
                name: "ThongTinVes");

            migrationBuilder.DropTable(
                name: "LoaiVes");

            migrationBuilder.DropTable(
                name: "MaGiamGias");
        }
    }
}

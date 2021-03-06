// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WFCity.Data.EF;

namespace WFCity.Data.Migrations
{
    [DbContext(typeof(dbContext))]
    [Migration("20220517095607_addOrder-KH")]
    partial class addOrderKH
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("WFCity.Data.Entities.AppConfig", b =>
                {
                    b.Property<string>("Key")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Key");

                    b.ToTable("AppConfigs");
                });

            modelBuilder.Entity("WFCity.Data.Entities.KhachHang", b =>
                {
                    b.Property<int>("KhachHangId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("DaDatVe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoDienThoai")
                        .HasColumnType("int");

                    b.HasKey("KhachHangId");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("WFCity.Data.Entities.LoaiVe", b =>
                {
                    b.Property<int>("LoaiVeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<double>("GiaVe")
                        .HasColumnType("float");

                    b.HasKey("LoaiVeId");

                    b.ToTable("LoaiVes");
                });

            modelBuilder.Entity("WFCity.Data.Entities.MaGiamGia", b =>
                {
                    b.Property<int>("MaGiamGiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool?>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SoLuongDaSuDung")
                        .HasColumnType("int");

                    b.Property<int?>("SoLuongSuDung")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(0);

                    b.Property<int?>("SoTien")
                        .HasColumnType("int");

                    b.Property<string>("TenMaGiamGia")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.Property<int?>("TyLe")
                        .HasColumnType("int");

                    b.HasKey("MaGiamGiaId");

                    b.ToTable("MaGiamGias");
                });

            modelBuilder.Entity("WFCity.Data.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KhachHangId")
                        .HasColumnType("int");

                    b.Property<int>("MaGiamGiaId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgayDatVe")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("TongTien")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WFCity.Data.Entities.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("ThongTinVeId")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("WFCity.Data.Entities.ThongTinVe", b =>
                {
                    b.Property<int>("ThongTinVeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<bool?>("DaXoa")
                        .HasColumnType("bit");

                    b.Property<decimal?>("GiaVe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("LoaiVeId")
                        .HasColumnType("int");

                    b.Property<int?>("MaGiamGiaId")
                        .HasColumnType("int");

                    b.Property<string>("MaVe")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<DateTime?>("NgayTaoVe")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ThuTuVe")
                        .HasColumnType("int");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ThongTinVeId");

                    b.HasIndex("LoaiVeId");

                    b.HasIndex("MaGiamGiaId");

                    b.ToTable("ThongTinVes");
                });

            modelBuilder.Entity("WFCity.Data.Entities.ThongTinVe", b =>
                {
                    b.HasOne("WFCity.Data.Entities.LoaiVe", null)
                        .WithMany("ThongTinVes")
                        .HasForeignKey("LoaiVeId");

                    b.HasOne("WFCity.Data.Entities.MaGiamGia", null)
                        .WithMany("ThongTinVes")
                        .HasForeignKey("MaGiamGiaId");
                });

            modelBuilder.Entity("WFCity.Data.Entities.LoaiVe", b =>
                {
                    b.Navigation("ThongTinVes");
                });

            modelBuilder.Entity("WFCity.Data.Entities.MaGiamGia", b =>
                {
                    b.Navigation("ThongTinVes");
                });
#pragma warning restore 612, 618
        }
    }
}

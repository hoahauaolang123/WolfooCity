using Microsoft.EntityFrameworkCore.Migrations;

namespace WFCity.Data.Migrations
{
    public partial class sp_DanhSachVe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var sp = @"Create Procedure [dbo].[DanhSachVe]
                        @MaVe nvarchar(50),
                        @LoaiVeId int,
                        @NgayTaoVe date,
                        @NgayBanVe date,
                        @TrangThai int -- 0 mới tạo, 1 đã xuất excel,2 đã bán , 3 đã hết hạn
                     as
                          Select ve.ThongTinVeId, ve.MaVe,lv.TenVe,ve.NgayTaoVe,ve.NgayBanVe,ve.TrangThai,kh.KhachHangId,kh.HoTen from ThongTinVes ve
                          inner join LoaiVes lv on ve.LoaiVeId = lv.LoaiVeId
                          left join  OrderItems odit on ve.ThongTinVeId = odit.ThongTinVeId
                          left join Orders od on od.OrderId = odit.OrderId
                          left join KhachHangs kh on od.KhachHangId = kh.KhachHangId
                          where (ve.DaXoa is null or ve.DaXoa !=1)
                          and (lv.DaXoa is null or lv.DaXoa !=1)
                          and (@MaVe ='null' or (ve.MaVe =@MaVe and @MaVe !='null'))
                          and (@LoaiVeId =-1 or (ve.LoaiVeId = @LoaiVeId and @LoaiVeId != -1))
                          and (@NgayTaoVe ='1/1/1900 12:00:00 AM' or (CONVERT(DATE, ve.NgayTaoVe) = @NgayTaoVe and @NgayTaoVe!='1/1/1900 12:00:00 AM'))
                          and (@NgayBanVe ='1/1/1900 12:00:00 AM' or (CONVERT(DATE, ve.NgayBanVe) = @NgayBanVe and @NgayBanVe !='1/1/1900 12:00:00 AM' ))
                           and  (
		                             @TrangThai = -1 or
									 (
										 (@TrangThai =0 and ve.TrangThai =0)
										  or (@TrangThai =1 and ve.TrangThai =1)
										  or (@TrangThai =2 and ve.NgayBanVe is not null)
										  or (@TrangThai =3 and DATEDIFF(month,ve.NgayBanVe,GETDATE()) >=5  and Day(ve.NgayBanVe) - Day(GETDATE()) <0) -- Tháng hiện tại - tháng bán > 5 và ngày mua - ngày hiện tại < 0
									  )
		                        )
					order by  ve.NgayBanVe desc";

            migrationBuilder.Sql(sp);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}

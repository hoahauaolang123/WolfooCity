using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Piranha.QuanLyVeInterface
{
    public interface IQuanLyVeService
    {
        bool TaoVe(int? SoLuongVe, int? LoaiVe);
        List<DanhSachVe> DanhSachVe(string MaVe, int? LoaiVeId, DateTime? NgayTaoVe, DateTime? NgayBanVe, int? TrangThai);
        List<DanhSachKhachHang> DanhSachKhachHang(string SoDienThoai,string HoTen,string Email);
        List<KhachHangDatHang> KhachHangDatHang(int? KhachHangId);
        List<ChiTietDonHang> ChiTietDonHang(int? OrderId);
        List<QuanLyDonHang> QuanLyDonHang(string MaDonHang, string SoDienThoai, string HoTen, string Email);
        List<MaGiamGia> QuanLyMaGiamGia(string TenMaGiamGia,int? TrangThai);
        List<XuatEx> QuanLyMaGiamGia();
    }

    public class DanhSachVe
    {
        public string TenVe { set; get; }
        public int? KhachHangId { set; get; }
        public string TenKhachHang { set; get; }
        public int ThongTinVeId { get; set; }
        public string MaVe { get; set; }
        public string NgayTaoVe { get; set; }
        public string NgayBanVe { get; set; }
        public int TrangThai { get; set; }
    }

    public class DanhSachKhachHang
    {
        public int KhachHangId { set; get; }
        public string SoDienThoai { set; get; }
        public string Email { set; get; }
        public string LanMuaCuoi { set; get; }
    }
    public class KhachHangDatHang
    {
        public int OrderId { set; get; }      
        public string NgayDatVe { set; get; }      
        public string TongTien { set; get; }
        public string NguoiDiKem { set; get; }
        public string GhiChu { set; get; }
        public string MaDonHang { set; get; }
        public string SoLuongVe { set; get; }
        public string TenMaGiamGia { set; get; }

    }
    public class ChiTietDonHang
    {
        public int OrderId { set; get; }
        public int ThongTinVeId { set; get; }
        public int OrderItemId { set; get; }
        public string MaVe { set; get; }
        public string TenVe { set; get; }
        public string GiaVe { set; get; }     
    }
    public class QuanLyDonHang  
    {
        public int OrderId { set; get; }
        public string NgayDatVe { set; get; }
        public string TongTien { set; get; }
        public string NguoiDiKem { set; get; }
        public string GhiChu { set; get; }
        public string MaDonHang { set; get; }
        public string SoLuongVe { set; get; }
        public string TenMaGiamGia { set; get; }
        public string HoTen { set; get; }
        public string SoDienThoai { set; get; }
        public string Email { set; get; }
    }
    public class MaGiamGia
    {
        public int MaGiamGiaId { set; get; }
        public string TenMaGiamGia { get; set; }
        public string NgayBatDau { set; get; }
        public string NgayKetThuc { set; get; }
        public int? TyLe { set; get; }
        public string SoTien { set; get; }
        public int? TrangThai { set; get; }
    }
    public class XuatEx
    {
        public string MaVe { set; get; }
    }
}

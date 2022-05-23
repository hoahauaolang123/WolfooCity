using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCity.Data.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime? NgayDatVe { get; set; }
        public int? MaGiamGiaId { get; set; }
        public int? KhachHangId { get; set; }
        public decimal? TongTien { get; set; }
        public int? NguoiDiKem { get; set; }
        public string GhiChu { get; set; }
        public int? ThuTuDonHang { set; get; }
        public string MaDonHang { set; get; }

    }
}

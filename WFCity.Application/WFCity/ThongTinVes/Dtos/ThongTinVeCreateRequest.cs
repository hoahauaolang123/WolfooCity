using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCity.Application.WFCity.ThongTinVes.Dtos
{
    public class ThongTinVeCreateRequest
    {
        public string MaVe { get; set; }
        public int? ThuTuVe { get; set; }
        public int? LoaiVeId { get; set; }
        public DateTime? NgayTaoVe { get; set; }
        public DateTime? NgayBanVe { get; set; }
        public int? TrangThai { get; set; }
        public int? SoDienThoai { get; set; }
        public int? MaGiamGiaId { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public bool? DaXoa { get; set; }
    }
}

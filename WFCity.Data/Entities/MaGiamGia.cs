using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCity.Data.Entities
{
    public class MaGiamGia
    {
        public int MaGiamGiaId { get; set; }
        public string TenMaGiamGia { get; set; }
        public int? SoLuongSuDung { get; set; }
        public int? SoLuongDaSuDung { get; set; }
        public int? TyLe { get; set; }
        public int? SoTien { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public int? TrangThai { get; set; }
        public bool? DaXoa { get; set; }
        public List<ThongTinVe> ThongTinVes { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCity.Data.Entities
{
    public class ThongTinVe
    {
        public int ThongTinVeId { get; set; }
        public string MaVe { get; set; }
        public int? ThuTuVe { get; set; }
        public DateTime? NgayTaoVe { get; set; }
        public DateTime? NgayBanVe { get; set; }
        
        public int? TrangThai { get; set; }
        public int? LoaiVeId { get; set; }
        public bool? DaXoa { get; set; }
        public decimal? GiaVe { get; set; }

    }
}

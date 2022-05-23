using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCity.Data.Entities
{
    public class LoaiVe
    {
        public int LoaiVeId { get; set; } 
        public double GiaVe { get; set; } 
        public string TenVe { get; set; }
        public bool? DaXoa { get; set; }
        public List<ThongTinVe> ThongTinVes { get; set; }
    }
}

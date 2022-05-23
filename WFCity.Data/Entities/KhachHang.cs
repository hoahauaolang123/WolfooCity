using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCity.Data.Entities
{
    public class KhachHang
    {
        public int KhachHangId { get; set; }
        public string SoDienThoai { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public bool? DaDatVe { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCity.Data.Entities
{
    public class OrderItem
    {
        public int OrderItemId { get; set; } 
        public int? OrderId { get; set; }
        public int? ThongTinVeId { get; set; }  
    }

}

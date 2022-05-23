using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFCity.Application.WFCity.Dtos
{
    public class PagedViewModel<T>
    {
        List<T> Items { set; get; }
        public int TotalRecord { set; get; }
    }
}

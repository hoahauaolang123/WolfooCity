using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piranha.Manager.Extensions
{
    public static class DataTableExtention
    {
        public static DataTable ToDataTable<T>(this IEnumerable<T> list)
        {
            var rs = new DataTable();
            rs.Columns.Add("Item", typeof(T));
            if (list != null)
            {
                foreach (var item in list)
                {
                    rs.Rows.Add(item);
                }
            }
            return rs;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFCity.Application.WFCity.Dtos;
using WFCity.Application.WFCity.ThongTinVes.Dtos;

namespace WFCity.Application.WFCity.ThongTinVes
{
    public interface IManageThongTinVeService
    {
        Task<int> Create(ThongTinVeCreateRequest request);
        Task<int> Update(ThongTinVeCreateRequest request);
        Task<int> Delete(int ThongTinVeId);
        Task<List<ThongTinVeViewModel>>  GetAll();
        Task<PagedViewModel<ThongTinVeViewModel>> GetAllPaging(string keyword,int pageIndex,int pageSize);
    }
}

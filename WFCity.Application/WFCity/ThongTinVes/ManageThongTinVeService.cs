using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFCity.Application.WFCity.Dtos;
using WFCity.Application.WFCity.ThongTinVes.Dtos;
using WFCity.Data.EF;
using WFCity.Data.Entities;


namespace WFCity.Application.WFCity.ThongTinVes
{
    internal class ManageThongTinVeService : IManageThongTinVeService
    {
        private readonly dbContext _dbContext;
        public ManageThongTinVeService(dbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<int> Create(ThongTinVeCreateRequest request)
        {
            var thongTinVe = new ThongTinVe()
            {
                MaVe = request.MaVe,
                ThuTuVe = request.ThuTuVe,
                LoaiVeId = request.LoaiVeId,
                NgayTaoVe = DateTime.Now,
                DaXoa = false,
                TrangThai= 0,                                              
            };
            _dbContext.ThongTinVes.Add(thongTinVe);
           return  await _dbContext.SaveChangesAsync();
        }
        public async Task<int> Update(ThongTinVeCreateRequest request)
        {
            throw new NotImplementedException();
        }
        public async Task<int> Delete(int ThongTinVeId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ThongTinVeViewModel>>  GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<PagedViewModel<ThongTinVeViewModel>>  GetAllPaging(string keyword, int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        
    }
}

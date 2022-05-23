using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFCity.Data.EF;
using WFCity.Data.Entities;

namespace Piranha.Manager.Services
{
    public class QuanLyVeService 
    {
        private readonly dbContext _dbContext;
        public QuanLyVeService(dbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public bool TaoVe(int? SoLuongVe, int? LoaiVe)
        {
            if (SoLuongVe >= 100 && SoLuongVe <= 10000)
            {
                var listInsertVe = new List<InsertVe>();
                var veCuoiCung = _dbContext.ThongTinVes.OrderByDescending(m => m.ThuTuVe).Select(m => m.ThuTuVe).FirstOrDefault();
                if (veCuoiCung == null)
                {
                    var count = 0;
                    for (int i = 0; i < SoLuongVe; i++)
                    {
                        count++;
                        var data = new InsertVe();
                        int soChuSo = (int)Math.Floor(Math.Log10(count) + 1);
                        switch (soChuSo)
                        {
                            case 1:
                                data.MaVe = "WFC" + "00000" + count;
                                data.ThuTuVe = count;
                                break;
                            case 2:
                                data.MaVe = "WFC" + "0000" + count;
                                data.ThuTuVe = count;
                                break;
                            case 3:
                                data.MaVe = "WFC" + "000" + count;
                                data.ThuTuVe = count;
                                break;
                            case 4:
                                data.MaVe = "WFC" + "00" + count;
                                data.ThuTuVe = count;
                                break;
                            case 5:
                                data.MaVe = "WFC" + "0" + count;
                                data.ThuTuVe = count;
                                break;
                            case 6:
                                data.MaVe = "WFC" + count;
                                data.ThuTuVe = count;
                                break;
                        }
                        listInsertVe.Add(data);
                    }

                }
                else
                {
                    int veCuoi = veCuoiCung ?? default(int);
                    for (int i = 0; i < SoLuongVe; i++)
                    {
                        veCuoi++;
                        var data = new InsertVe();
                        int soChuSo = (int)Math.Floor(Math.Log10(veCuoi) + 1);
                        switch (soChuSo)
                        {
                            case 1:
                                data.MaVe = "WFC" + "000000000" + veCuoi;
                                data.ThuTuVe = veCuoi;
                                break;
                            case 2:
                                data.MaVe = "WFC" + "00000000" + veCuoi;
                                data.ThuTuVe = veCuoi;
                                break;
                            case 3:
                                data.MaVe = "WFC" + "0000000" + veCuoi;
                                data.ThuTuVe = veCuoi;
                                break;
                            case 4:
                                data.MaVe = "WFC" + "000000" + veCuoi;
                                data.ThuTuVe = veCuoi;
                                break;
                            case 5:
                                data.MaVe = "WFC" + "00000" + veCuoi;
                                data.ThuTuVe = veCuoi;
                                break;
                            case 6:
                                data.MaVe = "WFC" + "0000" + veCuoi;
                                data.ThuTuVe = veCuoi;
                                break;

                            case 7:
                                data.MaVe = "WFC" + "000" + veCuoi;
                                data.ThuTuVe = veCuoi;
                                break;
                            case 8:
                                data.MaVe = "WFC" + "00" + veCuoi;
                                data.ThuTuVe = veCuoi;
                                break;
                            case 9:
                                data.MaVe = "WFC" + "0" + veCuoi;
                                data.ThuTuVe = veCuoi;
                                break;
                            case 10:
                                data.MaVe = "WFC" + veCuoi;
                                data.ThuTuVe = veCuoi;
                                break;
                        }
                        listInsertVe.Add(data);
                    }
                }
            }
            return true;
        }
    }
    public class InsertVe
    {
        public int ThuTuVe { set; get; }
        public string MaVe { set; get; }
    }
}

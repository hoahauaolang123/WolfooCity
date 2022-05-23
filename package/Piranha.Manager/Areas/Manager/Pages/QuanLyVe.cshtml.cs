using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Piranha.AspNetCore.SCHelpers;
using Piranha.QuanLyVeInterface;
using System;
using System.IO;
using System.Linq;
using ClosedXML.Excel;
using System.Data;
using DataTables.AspNet.Core;
using PagedList;

namespace Piranha.Manager.Areas.Manager
{
    [Authorize(Policy = Permission.Admin)]
    public class ThongKeVeModel : PageModel
    {
        private readonly ILogger<ThongKeVeModel> _logger;
        private readonly IQuanLyVeService _service;
        public ThongKeVeModel(IQuanLyVeService service, ILogger<ThongKeVeModel> logger)
        {
            _service = service;
            _logger = logger;
        }
        [HttpGet]
        public JsonResult OnGetDanhSachVe(IDataTablesRequest request,string MaVe, int? LoaiVeId, string NgayTaoVe, string NgayBanVe, int? TrangThai)
        {
            try
            {
                
                DateTime? ngayTaoVe = null;
                DateTime? ngayBanVe = null;
                if (!String.IsNullOrEmpty(NgayTaoVe))
                {
                    ngayTaoVe = TypeHelper.ToDate(NgayTaoVe);
                }
                if (!String.IsNullOrEmpty(NgayBanVe))
                {
                    ngayBanVe = TypeHelper.ToDate(NgayBanVe);
                }
                var pageNum = request.Start / request.Length + 1;
                var danhSach = _service.DanhSachVe(MaVe, LoaiVeId, ngayTaoVe, ngayBanVe, TrangThai);
                var rs = danhSach.ToPagedList(pageNum, request.Length);
                return new JsonResult(new { draw = request.Draw,
                    data = rs.Select(a => new
                    {
                        a.TenVe,
                        a.KhachHangId,
                        a.TenKhachHang,
                        a.ThongTinVeId,
                        a.MaVe,
                        a.NgayTaoVe,
                        a.NgayBanVe,
                        a.TrangThai
                    }).ToList(),
                    recordsTotal = rs.TotalItemCount,
                    recordsFiltered = rs.TotalItemCount 
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new JsonResult(ex);
            }


        }
        public FileResult OnPostExport()
        {
            var ngay = DateTime.Now;
            string NgayHomNay = ngay.ToString("dd/M/yyyy");
            DataTable dt = new DataTable("Danh sách mã vé");
            dt.Columns.AddRange(new DataColumn[1] { new DataColumn("Mã vé")});

            var list = _service.QuanLyMaGiamGia();

            foreach (var item in list)
            {
                dt.Rows.Add(item.MaVe);
            }

            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt);
                using (MemoryStream stream = new MemoryStream())
                {
                    wb.SaveAs(stream);
                    return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", NgayHomNay + "ma_ve.xlsx");
                }
            }
        }

    }

}

using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WFCity.Data.EF;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System;
using Piranha.Manager.Services;
using Microsoft.Extensions.Logging;
using Piranha.QuanLyVeInterface;

namespace Piranha.Manager.Areas.Manager.Pages
{
    [Authorize(Policy = Permission.Admin)]
  
    public class TaoVeModel : PageModel
    {
        private readonly ILogger<TaoVeModel> _logger;
        private readonly IQuanLyVeService _service;
        public TaoVeModel(IQuanLyVeService service, ILogger<TaoVeModel> logger)
        {
            _service = service;
            _logger = logger;
        }
        [HttpGet]
        public IActionResult OnGetTaoDuLieuVe(int? SoLuongVe,int? LoaiVe)
        {
            try
            {
                if (SoLuongVe >= 100 && SoLuongVe <= 10000 && LoaiVe != null)
                {
                    var rs = _service.TaoVe(SoLuongVe, LoaiVe);
                    return new JsonResult(rs);
                }
                return new JsonResult(false);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return new JsonResult(ex);
            }
          

        }      
    }

}

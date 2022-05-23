using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WFCity.Data.EF;
using Microsoft.AspNetCore.Mvc;
using Piranha.Manager.Services;
using System.IO;

namespace Piranha.Manager.Controllers
{
    public class QuanLyVeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

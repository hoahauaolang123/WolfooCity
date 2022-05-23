using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
namespace Piranha.Manager.Areas.Manager.Pages
{
    [Authorize(Policy = Permission.Admin)]
    public class Qlv_KhachHangModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}

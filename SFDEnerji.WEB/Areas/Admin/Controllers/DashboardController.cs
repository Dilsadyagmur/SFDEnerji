using Microsoft.AspNetCore.Mvc;

namespace SFDEnerji.WEB.Areas.Admin.Controllers
{
    public class DashboardController : ControllerBase
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}

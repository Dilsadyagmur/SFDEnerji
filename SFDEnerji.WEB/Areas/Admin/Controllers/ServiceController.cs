using Microsoft.AspNetCore.Mvc;

namespace SFDEnerji.WEB.Areas.Admin.Controllers
{
    public class ServiceController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

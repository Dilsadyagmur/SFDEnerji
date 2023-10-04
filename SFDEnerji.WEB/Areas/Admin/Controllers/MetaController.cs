using Microsoft.AspNetCore.Mvc;

namespace SFDEnerji.WEB.Areas.Admin.Controllers
{
    public class MetaController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

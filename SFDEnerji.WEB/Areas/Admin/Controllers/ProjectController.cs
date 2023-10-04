using Microsoft.AspNetCore.Mvc;

namespace SFDEnerji.WEB.Areas.Admin.Controllers
{
    public class ProjectController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

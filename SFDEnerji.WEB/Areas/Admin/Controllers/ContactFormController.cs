using Microsoft.AspNetCore.Mvc;

namespace SFDEnerji.WEB.Areas.Admin.Controllers
{
    public class ContactFormController : ControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

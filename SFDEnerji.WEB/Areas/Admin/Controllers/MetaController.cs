using Microsoft.AspNetCore.Mvc;
using SFDEnerji.Models.Concrete;
using SFDEnerji.Repository.Shared.Concrete;

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

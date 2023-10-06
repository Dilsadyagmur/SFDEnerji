using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using SFDEnerji.Models.Concrete;
using SFDEnerji.Repository.Shared.Abstract;
using SFDEnerji.Repository.Shared.Concrete;
using SFDEnerji.WEB.Areas.Admin.Models.DTO_s;
using System.Drawing.Text;
using System.Security.Claims;

namespace SFDEnerji.WEB.Areas.Admin.Controllers
{
    public class AppUserController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AppUserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;  
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View(); 
        }
        [HttpPost]
        public IActionResult Login(LoginDTO loginDTO)
        {
            AppUser user = _unitOfWork.Users.GetFirstOrDefault
                (l=>l.Name == loginDTO.UserName && l.Password == loginDTO.Password);
            if (user == null)
            {
                return BadRequest("Kullanıcı adı veya şifre hatalı.");
            }
            else
            {
              List<Claim> claims = new List<Claim>();   
              claims.Add( new Claim(ClaimTypes.Name, user.Name) );
              claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
              claims.Add(new Claim(ClaimTypes.Role, "Admin"));

              ClaimsIdentity claimsidentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                HttpContext.SignOutAsync(
                    CookieAuthenticationDefaults.AuthenticationScheme);
                HttpContext.SignInAsync
                  (CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsidentity), new AuthenticationProperties
                  { IsPersistent = loginDTO.IsRememberMe });
                return Ok();
            }
            return View();
        }
    }
}

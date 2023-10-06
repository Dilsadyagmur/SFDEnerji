namespace SFDEnerji.WEB.Areas.Admin.Models.DTO_s
{
    public class LoginDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsRememberMe { get; set; } = false;
    }
}

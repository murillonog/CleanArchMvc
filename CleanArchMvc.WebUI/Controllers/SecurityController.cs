using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchMvc.WebUI.Controllers
{
    [Authorize]
    public class SecurityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class AuthorizationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

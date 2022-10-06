using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class TownController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

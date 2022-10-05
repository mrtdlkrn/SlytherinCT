using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class AdvertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

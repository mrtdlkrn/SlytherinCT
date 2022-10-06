using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class AdvertController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListAdvert()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ListAdvertStatusHistory()
        {
            return View();
        }
    }
}

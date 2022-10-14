using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class CarHistoryController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}

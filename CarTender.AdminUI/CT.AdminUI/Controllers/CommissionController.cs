using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class CommissionController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddCommission()
        {

            return View();
        }

    }
}

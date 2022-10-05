using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class CommissionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

    }
}

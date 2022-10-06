using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class StatusController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class BuyerInfoController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult MessageContent()
        {
            return View();
        }
    }
}

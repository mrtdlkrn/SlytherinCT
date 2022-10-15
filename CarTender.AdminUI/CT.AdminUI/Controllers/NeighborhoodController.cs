using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class NeighborhoodController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}

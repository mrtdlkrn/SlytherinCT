using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserFavoriteCar()
        {
            return View();

        }
        public IActionResult UserCar()
        {
            return View();

        }
        
    }
}

using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class BuyNowSellController : Controller
    {
        public IActionResult Index()
        {
            return RedirectToAction("AddCar", ""); //todo: gelen sayfaya yönlendir 
        }
    }
}

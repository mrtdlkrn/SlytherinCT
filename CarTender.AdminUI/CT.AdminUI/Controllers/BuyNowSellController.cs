using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class BuyNowSellController : Controller
    {
        [HttpPost("/Index/id")]
        public IActionResult Index(int id)
        {
            return RedirectToAction("AddCar", ""); //todo: gelen sayfaya yönlendir 
        }        
    }
}

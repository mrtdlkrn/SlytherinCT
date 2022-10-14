using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class BuyNowSellController : Controller
    {
        [HttpGet("Index/{id}")]
        public IActionResult Index(int id)
        {
            return RedirectToAction("Index", "Car"); //todo: gelen sayfaya yönlendir 
        }
    }
}

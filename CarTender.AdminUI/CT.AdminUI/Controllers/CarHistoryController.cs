using Microsoft.AspNetCore.Mvc;
using System;

namespace CT.AdminUI.Controllers
{
    public class CarHistoryController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}

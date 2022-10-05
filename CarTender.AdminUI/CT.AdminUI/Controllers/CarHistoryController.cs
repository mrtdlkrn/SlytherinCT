using Microsoft.AspNetCore.Mvc;
using System;

namespace CT.AdminUI.Controllers
{
    public class CarHistoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ViewHistory()
        {
            return View();
        }
    }
}

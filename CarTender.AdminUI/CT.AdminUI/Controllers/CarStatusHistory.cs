﻿using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class CarStatusHistory : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
﻿using Microsoft.AspNetCore.Mvc;

namespace CT.AdminUI.Controllers
{
    public class TramerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
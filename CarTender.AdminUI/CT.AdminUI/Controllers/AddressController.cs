﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CT.AdminUI.Controllers
{
    public class AddressController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
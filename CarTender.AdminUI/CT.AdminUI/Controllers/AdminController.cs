using Business.Abstract;
using CarTender.AdminUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace CarTender.AdminUI.Controllers
{
    public class AdminController : Controller
    {
        private readonly ILogger<AdminController> _logger;
        private readonly IAPIService _apiService;

        public AdminController(ILogger<AdminController> logger, IAPIService apiService)
        {
            _logger = logger;
            _apiService = apiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            //IEnumerable<string> values;
            //string? HeaderValue = "";
            //if (Response.Headers.TryGetValue("X-BB-SESSION", out values))
            //{
            //    HeaderValue = values.FirstOrDefault();
            //}
            return View(new ErrorViewModel { StatusCode = Response.StatusCode,
                Header = Response.Headers.TryGetValue("X-BB-SESSION", out var values) ? values.FirstOrDefault() : null,Message = "Burkay" });
            
        }
    }
}
//RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifie
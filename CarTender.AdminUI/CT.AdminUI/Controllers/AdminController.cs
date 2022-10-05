using Business.Abstract;
using CarTender.AdminUI.Models;
using Entity.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

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

        public IActionResult ListTender()
        {
            return View();
        }
        [HttpGet]
        public IActionResult VehicleDetailInformation()
        {
            return View();
        }
        [HttpPost]
        public IActionResult VehicleDetailInformation(AddVehicle dto)
        {
            //await _apiService.AddVehicleDetailInformation(dto);
            //return RedirectToAction("VehicleDetailInformation");
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

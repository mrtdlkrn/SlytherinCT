using CarTender.AdminUI.Models;
using Common.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Linq;

namespace CarTender.AdminUI.Controllers
{
    public class AdminController : Controller
    {
        //todo : Api bağlantısı Yapılacak
        private readonly ILogger<AdminController> _logger;
        private readonly IBaseAPIService _apiService;

        public AdminController(ILogger<AdminController> logger, IBaseAPIService apiService)
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

        [Route("Admin/Error/{statusCode}")]
        public IActionResult Error(int statusCode)
        {
            // Error sayfalarinin goruntulenebilmesi icin launchSettings.json'dan IIS express'i Developement ayarindan Production ayarina getirmek gerekir.
            switch (statusCode)
            {
                case 404:
                    ViewBag.ErrorTitle = "Sayfa Bulunamadı";
                    ViewBag.ErrorContent = "Üzgünüz, aradığınız sayfayı bulamadık.";
                    break;
                case 401:
                    ViewBag.ErrorTitle = "Yetkisiz Giriş";
                    ViewBag.ErrorContent = "Üzgünüz, girmek istediğiniz sayfa için yetkiniz bulunmuyor.";
                    break;
                case 500:
                    ViewBag.ErrorTitle = "Sunucu Hatası";
                    ViewBag.ErrorContent = "Üzgünüz, sunucu şu anda isteğinize cevap veremiyor.";
                    break;
                case 503:
                    ViewBag.ErrorTitle = "Servis Kullanılamıyor";
                    ViewBag.ErrorContent = "Üzgünüz, sunucu şu anda bakımda veya isteğinize yanıt veremiyor lütfen tekrar deneyiniz.";
                    break;
            }
            ViewBag.StatusCode = statusCode;

            return View();
        }
    }
}
//RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifie
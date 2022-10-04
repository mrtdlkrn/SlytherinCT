using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace CarTender.AdminUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IAPIService _apiService;

        public AuthController(IAPIService apiService)
        {
            _apiService = apiService;
        }

        public IActionResult Login()
        {            
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
    }
}

using Business.Abstract;
using Entity.DTO;
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

        [HttpGet]
        public IActionResult Login()
        {            
            return View(new LoginDTO());
        }

        [HttpPost]
        public IActionResult Login(LoginDTO dto)
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

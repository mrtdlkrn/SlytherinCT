using Business.Abstract;
using Common.Abstract;
using Entity.DTO;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CarTender.AdminUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IApiService _apiService;

        public AuthController(IApiService apiService)
        {
            _apiService = apiService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            _apiService.Test("test");        
            return View(new LoginDTO());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginDTO dto)
        {            
            if(dto == null) return RedirectToAction("Register");

            var user = await _apiService.Post("auth/login",dto);

            if(user != null)
            {

            }

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

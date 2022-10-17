using Business.Abstract;
using Common.Abstract;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using FluentValidation.AspNetCore;
using CarTender.FluentValidation.DAL.AdminDAL.Login;
using CarTender.FluentValidation.DTO.AdminDTO.Login;
using Entity.DTO.Auth;

namespace CT.AdminUI.Controllers
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
            AdminLoginVAL validations = new AdminLoginVAL();
            ValidationResult validationResult = validations.Validate(new AdminLoginDTO
            {

                Email = dto.Email,
                Password = dto.Password
            });

            if (!validationResult.IsValid)
            {
                validationResult.AddToModelState(this.ModelState);

                TempData["Password"] = dto.Password;

                return View("Login", dto);
            }

            if (dto == null) return RedirectToAction("Register");

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

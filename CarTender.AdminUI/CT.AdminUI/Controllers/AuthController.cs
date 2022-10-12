using Business.Abstract;
using Common.Abstract;
using Entity.DTO;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using CarTender.FluentValidation.DAL;
using CarTender.FluentValidation.DTO;
using FluentValidation.AspNetCore;

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
            return View(new AdminLoginDTO());
        }

        [HttpPost]
        public async Task<IActionResult> Login(AdminLoginDTO dto)
        {
            AdminLoginDAL validations = new AdminLoginDAL();
            ValidationResult validationResult = validations.Validate(dto);

            if (!validationResult.IsValid)
            {
                validationResult.AddToModelState(this.ModelState);

                return View("Login", dto);
            }

            if (dto == null) return RedirectToAction("Register");

            var user = await _apiService.Post("auth/login", dto);

            if (user != null)
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

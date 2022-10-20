using Business.Abstract;
using CarTender.FluentValidation.VAL.AdminVAL.Login;
using CarTender.FluentValidation.DTO.AdminDTO.Login;
using Entity.DTO.Auth;
using FluentValidation.AspNetCore;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using CarTender.FluentValidation.VAL.AdminVAL.Register;
using CarTender.FluentValidation.DTO.AdminDTO.Register;
using CarTender.FluentValidation.VAL.AdminVAL.ForgotPassword;

namespace CT.AdminUI.Controllers
{
    public class AuthController : Controller
    {
        //todo : Api bağlantısı yapılacak
        private readonly IApiService _apiService;
        //private readonly CookieHelper cookieHelper;
        public AuthController(IApiService apiService)
        {
            _apiService = apiService;
            //this.cookieHelper = cookieHelper;            
        }

        [HttpGet]
        public IActionResult Login()
        {
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

            try
            {
                // todo: api/auth/login buradan gönderilecek.
                var result = await _apiService.Login(dto);
                if (result!=null)
                {
                    //cookieHelper.SetCookie();
                    return RedirectToAction("Index","Admin");
                }

                return View();
            }
            catch (System.Exception)
            {
                return BadRequest();
            }

        }
        [HttpGet]
        public IActionResult Register()
        {
            return View(new AdminRegisterDTO());
        }

        [HttpPost]
        public async Task<IActionResult> Register(AdminRegisterDTO dto)
        {
            RegisterVAL validations = new RegisterVAL();
            ValidationResult validationResult = validations.Validate(new RegisterDTO
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                Password = dto.Password,
                RePassword = dto.RePassword,
            });

            if (!validationResult.IsValid)
            {
                validationResult.AddToModelState(this.ModelState);

                TempData["Password"] = dto.Password;

                return View("Register", dto);
            }

            try
            {
                var register = await _apiService.Register(dto);
                if (register != null)
                {

                }
                return RedirectToAction("Login");
            }
            catch (Exception)
            {
                return BadRequest();
            }

        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View(new ForgotPasswordDTO());
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPassword(ForgotPasswordDTO dto)
        {
            ForgotPasswordVAL validations = new ForgotPasswordVAL();
            ValidationResult validationResult = validations.Validate(new CarTender.FluentValidation.DTO.AdminDTO.ForgotPassword.ForgotPasswordDTO
            {
                Email = dto.Email
            });
            if (!validationResult.IsValid)
            {
                validationResult.AddToModelState(this.ModelState);

                return View("Register", dto);
            }

            try
            {
                var forgotpassword = await _apiService.ForgotPassword(dto);
                if (forgotpassword != null)
                {

                }
                return RedirectToAction("Login");
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }
    }
}

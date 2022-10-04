using CarTender.API.Models.DTOs;
using CarTender.Business.Abstract;
using CarTender.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CarTender.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService authService;

        public AuthController(IAuthService authService, IConfiguration configuration = null)
        {
            this.authService = authService;
        }

        [HttpPost("login")]

        public IActionResult Login(LoginDTO dto)
        {
            var user = authService.Login("ahmet123", "ahmet123");

            // check user
            if (user == null) return BadRequest("User not found");

            // if user exists
            var token = authService.CreateToken(new User());
            return Ok(token);
        }



        [HttpPost("register")]
        public IActionResult Register(RegisterDTO dto)
        {
            var userExists = authService.IsUserExist(dto.Email);

            if (userExists)
            {
                return BadRequest("Kullanici mevcut");
            }

            authService.Register(new User(), dto.Password);
            var token = authService.CreateToken(new User());
            return Ok(token);
        }

    }
}

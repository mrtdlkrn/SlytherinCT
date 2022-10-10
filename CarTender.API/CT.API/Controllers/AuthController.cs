using CarTender.API.Models.DTOs;
using CarTender.Business.Abstract;
using CarTender.Entities;
using CT.API.Models.DTOs;
using CT.Log.Abstract;
using CT.Log.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NLog;

namespace CarTender.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        
        private readonly IAuthService authService;
        private readonly Logger logger = LogManager.GetCurrentClassLogger();

        public AuthController(IAuthService authService, IConfiguration configuration = null)
        {
            this.authService = authService;
        }

        [HttpPost("login")]

        public IActionResult Login(LoginDTO dto)
        {
            var user = authService.Login("sarp@gmail.com", "sarp123");

            // check user
            if (user == null) return BadRequest("User not found");

            // if user exists
            var token = authService.CreateToken(new User());
            return Ok(token);
        }



        [HttpPost("register")]
        public IActionResult Register(RabbitMQLoginDTO dto)
        {
            var userExists = authService.IsUserExist(dto.Email);

            if (userExists)
            {
                return BadRequest("Kullanici mevcut");
            }

            User user = new User()
            {
                Username = dto.Username,
                Customername = dto.Customername,
                Phone = dto.Phone,
                Email = dto.Email

            };

            authService.Register(user, dto.Password);
            var token = authService.CreateToken(user);
            //todo mesaj atma yeri RabbitMQ-Mert
            return Ok(token);
        }

        [HttpPost("CustomerRegister")]
        public IActionResult CustomerRegister(RabbitMQLoginDTO dto)
        {
            var CustomerExists = authService.IsUserExist(dto.Username);

            if (CustomerExists)
                return BadRequest("Kullanıcı mevcut");


            return Ok();
        }


        [HttpPost("log")]
        public IActionResult Logger()
        {

            logger.Info("test leoh");
            return Ok();
        }


    }
}

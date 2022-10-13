using CarTender.API.Models.DTOs;
using CarTender.Business.Abstract;
using CarTender.Entities;
using CT.API.Logging.Concrete;
using CT.API.Models.DTOs;
using CT.Common.Service;
using CT.Entities.Mail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Collections.Generic;
using System.Linq;

namespace CarTender.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly IAuthService authService;
        private readonly IQueueService queueService;
        private readonly IConfiguration configuration;
        private readonly Logger _logger;
        private static IDictionary<string, string> apiRoutes;

        public AuthController(IAuthService authService, IQueueService queueService, IConfiguration configuration = null)
        {
            this.authService = authService;
            this.queueService = queueService;
            this.configuration = configuration;
            string json = System.IO.File.ReadAllText("setting.json");
            dynamic jsonObj = JsonConvert.DeserializeObject<dynamic>(json)!;
            var loggerType = jsonObj.LoggerType.ToString();
            _logger = new(new Creater().FactoryMethod(loggerType));
            var _apiRoutes = jsonObj.ApiRoutes[0].Actions[0]; 
            apiRoutes = new Dictionary<string, string>();
            foreach (var action in _apiRoutes)
            {
                apiRoutes.Add(action.Name.ToString(), action.Value.ToString());
            }
        }

        [HttpPost]
        public IActionResult Login(LoginDTO dto)
        {
            string email = "ahmet@gmail.com";
            string password = "123";



            if (dto.Password != password || dto.Email != email)
            {
                _logger.Log("hatalı kullanıcı girişi");
                return BadRequest("kullanıcı bilgileri hatalı.");
            }

            _logger.Log(email + " kullanıcı giriş yaptı.");
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
                _logger.Log("mevcut kullanıcı kayıt yapmaya çalıştı");
                return BadRequest("Kullanici mevcut");
            }
            _logger.Log(dto.Email + " kayıt oldu");
            User user = new()
            {
                Id = 1,
                Username = dto.Username,
                Customername = dto.Customername,
                Phone = dto.Phone,
                Email = dto.Email

            };

            authService.Register(user, dto.Password);
            var token = authService.CreateToken(user);
            List<string> eposta = new()
            {
                user.Email
            };

            string domain = configuration.GetSection("Application:AppDomain").Value;
            string confirmationLink = domain + configuration.GetSection("Application:LoginPath").Value;
            confirmationLink += configuration.GetSection("Application:EmailConfirmation").Value;

            MailInfo mailInfo = new()
            {
                Topic = "Email Doğrulama",
                DestinationEmails = eposta,
                Context = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<title>Page Title</title>\r\n</head>\r\n<body>\r\n\r\n<h1>This is a Heading</h1>\r\n<p>This is a paragraph.</p>\r\n\r\n<a href=\"" + confirmationLink + token.Token.ToString() + "\">Email Doğrula</a></body>\r\n</html>" //todo : İçerik girilecek
            };
            ConnectionFactory connectionFactory = new()
            {
                HostName = "localhost",
                Password = "guest",
                UserName = "guest",
            };
            var queue = "Register";
            var exchange = "RegisterExchange";
            var routingKey = "RegisterMail";
            queueService.CreateQueue(connectionFactory, queue);
            queueService.CreateExchange(connectionFactory, exchange);
            queueService.CreateBinding(connectionFactory, queue, exchange, routingKey);
            queueService.Publish(connectionFactory, mailInfo, exchange, routingKey);

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

            _logger.Log("Hello, this is the index!");
            return Ok();
        }


    }
}

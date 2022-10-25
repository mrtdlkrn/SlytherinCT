using CarTender.Business.Abstract;
using CarTender.Core.Security.JWT;
using CarTender.Core.Utilities;
using CT.API.Logging.Concrete;
using CT.Common.Service;
using CT.Entities.Auth;
using CT.Entities.Entities;
using CT.Entities.Mail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Collections.Generic;

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

        [HttpPost("Login")]
        public IActionResult Login(LoginDTO dto)
        {
            var loginResult = authService.Login(dto.Email, dto.Password);

            if (!loginResult.Success)
            {
                _logger.Log("Hatalı kullanıcı girişi");
                return BadRequest(loginResult.Message);
            }
            _logger.Log(dto.Email + " giriş yaptı.");
            return Ok(loginResult);
        }

        [HttpPost("Register")]
        public IActionResult Register(RabbitMQLoginDTO dto)
        {
            User user = new()
            {
                Id = 1,
                Username = dto.Username,
                Customername = dto.Customername,
                Phone = dto.Phone,
                Email = dto.Email
            };

            var registerResult = authService.Register(user, dto.Password);

            if (!registerResult.Success)
            {
                _logger.Log("mevcut kullanıcı kayıt yapmaya çalıştı");
                return BadRequest(registerResult.Message);
            }
            
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
            _logger.Log(dto.Email + " kayıt oldu");
            return Ok(token);
        }

        // todo: burası tam olarak ne için kullanılacak?

        [HttpPost("CustomerRegister")]
        public IActionResult CustomerRegister(RabbitMQLoginDTO dto)
        {
            User user = new()
            {
                Id = 1,
                Username = dto.Username,
                Customername = dto.Customername,
                Phone = dto.Phone,
                Email = dto.Email
            };

            var registerResult = authService.Register(user, dto.Password);

            if (!registerResult.Success)
            {
                _logger.Log("mevcut kullanıcı kayıt yapmaya çalıştı");
                return BadRequest(registerResult.Message);
            }

            return Ok(registerResult.Message);
        }

        [HttpPost("Logger")]
        public IActionResult Logger()
        {
            _logger.Log("Hello, this is the index!");
            return Ok();
        }

    }
}

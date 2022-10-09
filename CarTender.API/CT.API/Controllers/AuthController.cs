using CarTender.API.Models.DTOs;
using CarTender.Business.Abstract;
using CarTender.Entities;
using CT.API.Models.DTOs;
using CT.Common.Service;
using CT.Entities.Mail;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Configuration;
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

        public AuthController(IAuthService authService,IQueueService queueService , IConfiguration configuration = null)
        {
            this.authService = authService;
            this.queueService = queueService;
            this.configuration = configuration;
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
                Id = 1,
                Username = dto.Username,
                Customername = dto.Customername,
                Phone = dto.Phone,
                Email = dto.Email

            };

            authService.Register(user, dto.Password);
            var token = authService.CreateToken(user);
            List<string> eposta = new List<string>();
            eposta.Add(user.Email);

            string domain = configuration.GetSection("Application:AppDomain").Value;
            string confirmationLink = domain + configuration.GetSection("Application:LoginPath").Value;
            confirmationLink += configuration.GetSection("Application:EmailConfirmation").Value;

            MailInfo mailInfo = new MailInfo()
            {
                Topic = "Email Doğrulama",
                DestinationEmails = eposta,
                Context = "<!DOCTYPE html>\r\n<html>\r\n<head>\r\n<title>Page Title</title>\r\n</head>\r\n<body>\r\n\r\n<h1>This is a Heading</h1>\r\n<p>This is a paragraph.</p>\r\n\r\n<a href=\""+confirmationLink+token.Token.ToString()+"\">Email Doğrula</a></body>\r\n</html>" //todo : İçerik girilecek
            };
            ConnectionFactory connectionFactory = new ConnectionFactory()
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
    }
}

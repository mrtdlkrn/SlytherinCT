using CarTender.Core.Utilities;
using CT.Business.Abstract;
using CT.Common.Service;
using CT.Entities.Entities;
using CT.Entities.Mail;
using Microsoft.Extensions.Configuration;
using RabbitMQ.Client;
using System.Collections.Generic;

namespace CT.Business.Concrete
{
    public class NotificationManager : INotificationService
    {
        private readonly IQueueService queueService;
        private readonly IConfiguration configuration;

        public NotificationManager(IQueueService queueService, IConfiguration configuration = null)
        {
            this.queueService = queueService;
            this.configuration = configuration;
        }

        public IResult SendNotification(Message message)
        {
            List<string> eposta = new()
            {
                message.EMail
            };

            string domain = configuration.GetSection("Application:AppDomain").Value;
            string confirmationLink = domain + configuration.GetSection("Application:LoginPath").Value;
            confirmationLink += configuration.GetSection("Application:EmailConfirmation").Value; // todo: tanımlanmış ama kullanılmamış.

            MailInfo mailInfo = new()
            {
                Topic = "CarTender Bildirim",
                DestinationEmails = eposta,
                Context = message.MessageContent //todo : İçerik girilecek
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

            return new SuccessResult("Email gönderme başarılı",200);
        }
    }
}

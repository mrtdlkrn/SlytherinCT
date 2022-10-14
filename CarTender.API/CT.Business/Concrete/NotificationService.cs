using CarTender.Business.Abstract;
using CarTender.Entities;
using CT.Business.Abstract;
using CT.Entities;
using CT.Entities.Mail;
using Microsoft.AspNetCore.Connections;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RabbitMQ.Client;
using CT.Common.Service;
using Microsoft.AspNetCore.Http;

namespace CT.Business.Concrete
{
    public class NotificationService : INotificationService
    {
        private readonly IQueueService queueService;
        private readonly IConfiguration configuration;

        public NotificationService(IQueueService queueService, IConfiguration configuration = null)
        {
            this.queueService = queueService;
            this.configuration = configuration;
        }
        
        public bool SendNotification(Message message)
        {
           



            
            List<string> eposta = new()
            {
                message.EMail
            };

            string domain = configuration.GetSection("Application:AppDomain").Value;
            string confirmationLink = domain + configuration.GetSection("Application:LoginPath").Value;
            confirmationLink += configuration.GetSection("Application:EmailConfirmation").Value;

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

            return true;
        }
    }
}

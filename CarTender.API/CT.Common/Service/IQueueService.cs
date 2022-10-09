using CT.Entities.Mail;
using RabbitMQ.Client;

namespace CT.Common.Service
{
    public interface IQueueService
    {
        public void CreateQueue(ConnectionFactory connectionFactory, string queue);
        public void CreateExchange(ConnectionFactory connectionFactory, string exchange);
        public void CreateBinding(ConnectionFactory connectionFactory, string queue, string exchange, string routingKey);
        public void Publish(ConnectionFactory connectionFactory, MailInfo mailInfo, string exchange, string routingKey);
    }
}

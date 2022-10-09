using CT.Entities.Mail;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace CT.Common.Service
{
    public class QueueService : IQueueService
    {
        public void CreateQueue(ConnectionFactory connectionFactory, string queue)
        {
            using (var connection = connectionFactory.CreateConnection())
            using (var model = connection.CreateModel())
            {
                // Create Queue
                model.QueueDeclare(queue, true, false, false, null);
            }
        }
        public void CreateExchange(ConnectionFactory connectionFactory, string exchange)
        {
            using (var connection = connectionFactory.CreateConnection())
            using (var model = connection.CreateModel())
            {
                // Create Exchange
                model.ExchangeDeclare(exchange, ExchangeType.Direct);
            }
        }
        public void CreateBinding(ConnectionFactory connectionFactory, string queue, string exchange, string routingKey)
        {
            using (var connection = connectionFactory.CreateConnection())
            using (var model = connection.CreateModel())
            {
                // Bind Queue to Exchange
                model.QueueBind(queue, exchange, routingKey);
            }
        }
        public void Publish(ConnectionFactory connectionFactory, MailInfo mailInfo, string exchange, string routingKey)
        {
            using (var connection = connectionFactory.CreateConnection())
            using (var model = connection.CreateModel())
            {
                var properties = model.CreateBasicProperties();
                properties.Persistent = false;

                string message = JsonConvert.SerializeObject(mailInfo);
                byte[] messagebuffer = Encoding.Default.GetBytes(message);

                model.BasicPublish(exchange, routingKey, properties, messagebuffer);
            }
        }
    }
}


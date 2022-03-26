using Domain.Interfaces;
using Domain.Models;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using System.Text.Json;

namespace AssociadoConsumer
{
    public class AssociadoConsumer 
    {
        private readonly IAssociadoRepository _associadoRepository;

        public AssociadoConsumer(IAssociadoRepository associadoRepository)
        {
            _associadoRepository = associadoRepository;
        }

      
        public void Consumer()
        {
            //var factory = new ConnectionFactory() { HostName = "localhost" };

            var factory = new ConnectionFactory()
            {
                HostName = "192.168.100.5",
                Port = AmqpTcpEndpoint.UseDefaultPort,
                UserName = "associado",
                Password = "associado"
            };

            using (var connection = factory.CreateConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.QueueDeclare(queue: "AssociadoQueue",
                        durable: false,
                        exclusive: false,
                        autoDelete: false,
                        arguments: null);

                    var consumer = new EventingBasicConsumer(channel);
                    consumer.Received += (model, ea) =>
                    {

                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body.Span);
                        Associado associado = JsonSerializer.Deserialize<Associado>(message);
                        Console.WriteLine(associado.Nome);
                        _associadoRepository.PostCadastroAssociado(associado);
                      

                    };

                    channel.BasicConsume(queue: "AssociadoQueue",
                                        autoAck: true,
                                        consumer: consumer);
                    System.Threading.Thread.Sleep(2000);


                    Console.WriteLine("Consumer Funcionando");
                    Console.ReadLine();
                }
            }

        }


    }
}

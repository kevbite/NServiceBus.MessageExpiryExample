using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NServiceBus.MessageExpiryExample.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var configuration = new BusConfiguration();

            configuration.UsePersistence<InMemoryPersistence>();

            configuration.UseTransport<RabbitMQTransport>();

            using (var bus = Bus.CreateSendOnly(configuration))
            {
                var sagaExampleClient = new MessageExpiryExampleClient(bus);

                sagaExampleClient.Run();
            }
        }
    }

    public class MessageExpiryExampleClient
    {
        private readonly ISendOnlyBus _bus;

        public MessageExpiryExampleClient(ISendOnlyBus bus)
        {
            _bus = bus;
        }

        public void Run()
        {

        }
    }
}

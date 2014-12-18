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
}

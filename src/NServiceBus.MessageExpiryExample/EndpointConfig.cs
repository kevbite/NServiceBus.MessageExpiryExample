using NServiceBus.MessageExpiryExample.CommandHandlers;

namespace NServiceBus.MessageExpiryExample
{
    public class EndpointConfig : IConfigureThisEndpoint
    {
        public void Customize(BusConfiguration configuration)
        {
            configuration.UsePersistence<InMemoryPersistence>();

            configuration.UseTransport<RabbitMQTransport>();

            configuration.LoadMessageHandlers<First<TimeToLiveCommandHandler>>();
        }
    }
}

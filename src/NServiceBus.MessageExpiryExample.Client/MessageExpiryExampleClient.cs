using System;
using NServiceBus.MessageExpiryExample.Messages.Commands;

namespace NServiceBus.MessageExpiryExample.Client
{
    public class MessageExpiryExampleClient
    {
        private readonly ISendOnlyBus _bus;

        public MessageExpiryExampleClient(ISendOnlyBus bus)
        {
            _bus = bus;
        }

        public void Run()
        {
            ConsoleKey? key = null;

            do
            {
                if (key == ConsoleKey.C)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Sending Create Application Command");
                    Console.ResetColor();

                    var command = new CreateApplicationCommand()
                    {
                        ApplicationId = Guid.NewGuid(),
                        FirstName = "foo",
                        LastName = "bar",
                        TTL = DateTime.Now.AddSeconds(5)
                    };

                    _bus.Send(command);
                }

                key = Console.ReadKey().Key;
            } while (key != ConsoleKey.Q);
        }
    }
}
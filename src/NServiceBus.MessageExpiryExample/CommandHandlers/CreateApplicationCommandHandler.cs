using System;
using NServiceBus.MessageExpiryExample.Messages.Commands;

namespace NServiceBus.MessageExpiryExample.CommandHandlers
{
    public class CreateApplicationCommandHandler : IHandleMessages<CreateApplicationCommand>
    {
        private readonly IBus _bus;

        public CreateApplicationCommandHandler(IBus bus)
        {
            _bus = bus;
        }

        public void Handle(CreateApplicationCommand message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Creating Application :" + message.ApplicationId);
            Console.ResetColor();

            _bus.Send(message);
            _bus.Send(message);
            _bus.Send(message);

            throw new Exception("boom");
        }
    }
}

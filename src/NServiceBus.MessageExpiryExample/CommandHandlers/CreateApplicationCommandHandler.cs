using System;
using NServiceBus.MessageExpiryExample.Messages.Commands;

namespace NServiceBus.MessageExpiryExample.CommandHandlers
{
    public class CreateApplicationCommandHandler : IHandleMessages<CreateApplicationCommand>
    {
        public void Handle(CreateApplicationCommand message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Creating Application :"+ message.ApplicationId);
            Console.ResetColor();
        }
    }
}

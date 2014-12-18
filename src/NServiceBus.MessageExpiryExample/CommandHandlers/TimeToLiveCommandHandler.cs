using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus.MessageExpiryExample.Messages.Commands;

namespace NServiceBus.MessageExpiryExample.CommandHandlers
{
    public class TimeToLiveCommandHandler : IHandleMessages<ITimeToLiveCommand>
    {
        private readonly IBus _bus;

        public TimeToLiveCommandHandler(IBus bus)
        {
            _bus = bus;
        }

        public void Handle(ITimeToLiveCommand message)
        {
            if (DateTime.Now > message.TTL)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Creating Application Message Expired");
                Console.ResetColor();

                _bus.DoNotContinueDispatchingCurrentMessageToHandlers();
            }
        }
    }
}

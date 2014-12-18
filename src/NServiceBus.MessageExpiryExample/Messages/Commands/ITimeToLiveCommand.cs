using System;

namespace NServiceBus.MessageExpiryExample.Messages.Commands
{
    public interface ITimeToLiveCommand : ICommand
    {
        DateTime TTL { get; set; }
    }
}
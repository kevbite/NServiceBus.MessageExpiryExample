using System;

namespace NServiceBus.MessageExpiryExample.Messages.Commands
{
    public class CreateApplicationCommand : ITimeToLiveCommand
    {
        public Guid ApplicationId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime TTL { get; set; }
    }
}

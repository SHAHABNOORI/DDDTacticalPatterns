using System;
using DDDTacticalPatterns.DomainEvents.CoreDomain;
using DDDTacticalPatterns.DomainEvents.Frameworks;

namespace DDDTacticalPatterns.DomainEvents.ApplicationService
{
    public class SendSmsPersonDeactivatedEventHandler : IEventHandler<PersonDeactivated>
    {
        public void Handle(PersonDeactivated @event)
        {
            Console.WriteLine($"Send Sms to {@event.Mobile}");
        }
    }
}
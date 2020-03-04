using System;
using DDDTacticalPatterns.DomainEvents.CoreDomain;
using DDDTacticalPatterns.DomainEvents.Frameworks;

namespace DDDTacticalPatterns.DomainEvents.ApplicationService
{
    public class SendEmailPersonDeactivatedEventHandler : IEventHandler<PersonDeactivated>
    {
        public void Handle(PersonDeactivated @event)
        {
            Console.WriteLine($"Send email to {@event.Email}");
        }
    }
}
using DDDTacticalPatterns.DomainEvents.Frameworks;

namespace DDDTacticalPatterns.DomainEvents.CoreDomain
{
    public class PersonDeactivated : IDomainEvent
    {
        public int Id { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }
    }
}
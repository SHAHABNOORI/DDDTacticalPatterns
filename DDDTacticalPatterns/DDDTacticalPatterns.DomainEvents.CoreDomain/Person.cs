using System;
using DDDTacticalPatterns.DomainEvents.Frameworks;

namespace DDDTacticalPatterns.DomainEvents.CoreDomain
{
    public class Person : BaseEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public bool IsActive { get; set; }

        public void Deactivate()
        {
            IsActive = false;
            AddEvent(new PersonDeactivated()
            {
                Id = Id,
                Mobile = Mobile,
                Email = Email
            });
        }
    }
}

using System.Collections.Generic;

namespace DDDTacticalPatterns.DomainEvents.CoreDomain
{
    public interface IPersonRepository
    {
        Person Get(int personId);
        List<Person> GetAll();
    }
}
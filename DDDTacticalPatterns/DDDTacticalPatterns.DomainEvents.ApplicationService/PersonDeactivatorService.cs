using System.Linq;
using DDDTacticalPatterns.DomainEvents.CoreDomain;
using DDDTacticalPatterns.DomainEvents.Frameworks;

namespace DDDTacticalPatterns.DomainEvents.ApplicationService
{
    public class PersonDeactivatorService
    {
        private readonly FakePersonRepository _repository;
        private readonly IEventDispatcher _eventDispatcher;

        public PersonDeactivatorService(FakePersonRepository repository, IEventDispatcher eventDispatcher)
        {
            _repository = repository;
            _eventDispatcher = eventDispatcher;
        }

        public void Execute(int personId)
        {
            var person = _repository.Get(personId);
            person.Deactivate();
            _eventDispatcher.Dispatch(person.Events.ToArray());
            //Send Email
            //Send Sms
        }
    }
}

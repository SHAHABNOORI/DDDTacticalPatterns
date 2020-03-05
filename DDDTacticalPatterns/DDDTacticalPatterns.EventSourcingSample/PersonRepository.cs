using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace DDDTacticalPatterns.EventSourcingSample
{
    public class PersonRepository : IPersonRepository
    {
        readonly EventDataRepository _eventDataRepository = new EventDataRepository();
        public Person Get(int id)
        {
            var events = _eventDataRepository.GetEventDatas(nameof(Person), id);
            Person person = new Person();
            List<IEvent> myevents = new List<IEvent>();
            foreach (var item in events)
            {
                switch (item.EventType)
                {
                    case nameof(PersonCreated):
                        PersonCreated personCreated = JsonConvert.DeserializeObject<PersonCreated>(item.EventSerializedData);
                        myevents.Add(personCreated);
                        break;
                    case nameof(PersonEmailUpdated):
                        PersonEmailUpdated personEmailUpdate = JsonConvert.DeserializeObject<PersonEmailUpdated>(item.EventSerializedData);
                        myevents.Add(personEmailUpdate);

                        break;
                }
            }
            person.LoadFromEvents(myevents);
            return person;

        }

        public Person Get(int id, int verion)
        {
            var events = _eventDataRepository.GetEventDatas(nameof(Person), id);
            var tempEvents = events.Take(verion);
            Person person = new Person();
            List<IEvent> myevents = new List<IEvent>();
            foreach (var item in tempEvents)
            {
                switch (item.EventType)
                {
                    case nameof(PersonCreated):
                        PersonCreated personCreated = JsonConvert.DeserializeObject<PersonCreated>(item.EventSerializedData);
                        myevents.Add(personCreated);
                        break;
                    case nameof(PersonEmailUpdated):
                        PersonEmailUpdated personEmailUpdate = JsonConvert.DeserializeObject<PersonEmailUpdated>(item.EventSerializedData);
                        myevents.Add(personEmailUpdate);

                        break;
                }
            }
            person.LoadFromEvents(myevents);
            return person;

        }
    }
}
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace DDDTacticalPatterns.EventSourcingSample
{
    public class EventDataRepository
    {
        private readonly List<EventData> _eventDatas = new List<EventData>();

        public EventDataRepository()
        {
            _eventDatas.Add(new EventData
            {
                EventDataId = 1,
                EntityType = nameof(Person),
                EventType = nameof(PersonCreated),
                EntityId = 1,
                EventSerializedData = JsonConvert.SerializeObject(new PersonCreated
                {
                    Email = "ar@gmail.com",
                    FirstName = "Alireza",
                    LastName = "Oroumand",
                    Id = 1
                })

            });
            _eventDatas.Add(new EventData
            {
                EventDataId = 2,
                EntityType = nameof(Person),
                EventType = nameof(PersonEmailUpdated),
                EntityId = 1,
                EventSerializedData = JsonConvert.SerializeObject(new PersonEmailUpdated
                {
                    Email = "oroumand@gmail.com",
                })

            });
            _eventDatas.Add(new EventData
            {
                EventDataId = 3,
                EntityType = nameof(Person),
                EventType = nameof(PersonCreated),
                EntityId = 2,
                EventSerializedData = JsonConvert.SerializeObject(new PersonCreated
                {
                    Email = "lotfi@gmail.com",
                    FirstName = "Mohammad",
                    LastName = "Lotfi",
                    Id = 2
                })

            });
        }

        public List<EventData> GetEventDatas(string entityType, int entityId)
        {
            List<EventData> result = _eventDatas.Where
                (c => c.EntityType == entityType && c.EntityId == entityId).ToList();
            return result;
        }
    }

}
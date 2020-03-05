using System.Collections.Generic;

namespace DDDTacticalPatterns.EventSourcingSample
{
    public abstract class BaseEntity
    {
        private readonly List<IEvent> _events = new List<IEvent>();

        public IEnumerable<IEvent> Events => _events;

        public void Add(IEvent @event)
        {
            _events.Add(@event);
        }
    }
}
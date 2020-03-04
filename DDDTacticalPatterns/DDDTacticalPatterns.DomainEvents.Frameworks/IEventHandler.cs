namespace DDDTacticalPatterns.DomainEvents.Frameworks
{
    public interface IEventHandler<in T> where T:IDomainEvent
    {
       void Handle(T @event);
    }
} 
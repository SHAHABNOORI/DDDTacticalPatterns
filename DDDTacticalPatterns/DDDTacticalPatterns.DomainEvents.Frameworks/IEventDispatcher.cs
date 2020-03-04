namespace DDDTacticalPatterns.DomainEvents.Frameworks
{
    public interface IEventDispatcher
    {
        void Dispatch<T>(params T[] events) where T : IDomainEvent;
    }
}
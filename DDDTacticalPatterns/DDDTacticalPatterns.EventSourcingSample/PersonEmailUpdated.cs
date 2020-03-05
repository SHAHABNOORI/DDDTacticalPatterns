namespace DDDTacticalPatterns.EventSourcingSample
{
    public class PersonEmailUpdated : IEvent
    {
        public string Email { get; set; }

    }
}
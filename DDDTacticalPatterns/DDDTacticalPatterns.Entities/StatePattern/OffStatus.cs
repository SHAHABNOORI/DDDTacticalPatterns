namespace DDDTacticalPatterns.Entities.StatePattern
{
    public class OffStatus : ITvPowerAction
    {
        public string Status() => "On";
    }
}
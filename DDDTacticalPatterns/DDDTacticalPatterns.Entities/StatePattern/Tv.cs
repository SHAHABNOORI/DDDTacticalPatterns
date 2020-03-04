namespace DDDTacticalPatterns.Entities.StatePattern
{
    public class Tv
    {
        private ITvPowerAction _tvPowerAction;

        public bool IsOn { get; set; }

        public string Status { get; set; }

        public void PowerPush()
        {
            //Without State Pattern
            //Status = IsOn ? "Off" : "On";

            //With State Pattern
            Status = _tvPowerAction.Status();
        }
    }
}
namespace DDDTacticalPatterns.ValueObjects.MoneyV1
{
    public class Money
    {
        protected readonly decimal Value;

        public Money() : this(0)
        {

        }

        public Money(decimal value)
        {
            Value = value;
        }
    }
}
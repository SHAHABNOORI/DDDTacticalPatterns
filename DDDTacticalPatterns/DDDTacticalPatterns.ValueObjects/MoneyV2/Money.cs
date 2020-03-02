namespace DDDTacticalPatterns.ValueObjects.MoneyV2
{
    public class Money : BaseValueObject<Money>
    {
        protected readonly decimal Value;

        public Money() : this(0)
        {

        }

        public Money(decimal value)
        {
            Value = value;
        }

        protected override bool IsEqual(Money other)
        {
            return Value == other.Value;
        }

        protected override int GetHashCodeCore()
        {
            return Value.GetHashCode();
        }
    }
}
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

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            var valueObject = obj as Money;

            if (ReferenceEquals(valueObject, null))
                return false;

            return this.Value == valueObject.Value;
        }

        public static bool operator ==(Money a, Money b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(Money a, Money b)
        {
            return !(a == b);
        }
    }
}
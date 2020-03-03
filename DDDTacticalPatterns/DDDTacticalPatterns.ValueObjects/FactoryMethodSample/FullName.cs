namespace DDDTacticalPatterns.ValueObjects.FactoryMethodSample
{
    public class FullName : BaseValueObject<FullName>
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public FullName()
        {

        }

        public static FullName Create(string firstName, string lastName)
        {
            Validate(firstName, lastName);

            return new FullName()
            {
                FirstName = firstName,
                LastName = lastName
            };
        }

        public static FullName CreateCheckLength(string firstName, string lastName) 
        {
            Validate(firstName, lastName);

            ValidateFirstNameLength(firstName);

            return new FullName()
            {
                FirstName = firstName,
                LastName = lastName
            };
        }

        private static void ValidateFirstNameLength(string firstName)
        {
            if (firstName.Length < 2)
            {
                throw new FirstNameLengthIsInvalid();
            }
        }

        private static void Validate(string firstName, string lastName)
        {
            if (string.IsNullOrEmpty(firstName))
            {
                throw new FirstNameIsRequired();
            }

            if (string.IsNullOrEmpty(lastName))
            {
                throw new LastNameIsRequired();
            }
        }

        protected override bool IsEqual(FullName other)
        {
            return ((FirstName == other.FirstName) && (LastName == other.LastName));
        }

        protected override int GetHashCodeCore()
        {
            return (FirstName + LastName).GetHashCode();
        }
    }
}
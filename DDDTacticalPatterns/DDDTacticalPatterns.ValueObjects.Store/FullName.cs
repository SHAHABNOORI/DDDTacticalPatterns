namespace DDDTacticalPatterns.ValueObjects.Store
{
    public class FullName
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString() => $"{FirstName} - {LastName}";

        public static FullName CreateFromString(string fullName)
        {
            var split = fullName.Split("-");
            return new FullName()
            {
                FirstName = split[0],
                LastName = split[1]
            };
        }
    }
}
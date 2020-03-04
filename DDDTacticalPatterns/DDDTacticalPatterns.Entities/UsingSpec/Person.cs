using System;

namespace DDDTacticalPatterns.Entities.UsingSpec
{
    public class Person
    {
        internal IsGraterThanOrEqualAgePerson IsAdult { get; set; } =
            new IsGraterThanOrEqualAgePerson(18);

        public int Id { get; protected set; }

        public DateTime BirthDate { get; protected set; }

        public Person(int id, DateTime birthDate)
        {

        }
        public bool AllowAdultAccess()
        {
            return IsAdult.IsSatisfiedBy(this);
        }
    }
}
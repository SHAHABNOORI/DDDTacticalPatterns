using System;

namespace DDDTacticalPatterns.Entities.Specifications
{
    public class Person
    {
        public IsGraterThanOrEqualAgePerson IsAdult { get; set; } =
            new IsGraterThanOrEqualAgePerson(18);

        public int Id { get; protected set; }

        public DateTime BirthDate { get; protected set; }

        public Person(int id, DateTime birthDate)
        {
            Id = id;
            BirthDate = birthDate; 
        }

        public bool AllowAdultAccess()
        {
            return IsAdult.IsSatisfiedBy(this);
        }
    }
}
using System;

namespace DDDTacticalPatterns.Entities.Specifications
{
    public class IsGraterThanOrEqualAgePerson : ISpecification<Person>
    {
        private readonly int _minValidDate;

        public IsGraterThanOrEqualAgePerson(int minValidDate)
        {
            this._minValidDate = minValidDate;
        }
        
        public bool IsSatisfiedBy(Person entity)
        {
            var age = (DateTime.Now - entity.BirthDate).TotalDays % 365;
            return age >= _minValidDate;
        }
    }
}

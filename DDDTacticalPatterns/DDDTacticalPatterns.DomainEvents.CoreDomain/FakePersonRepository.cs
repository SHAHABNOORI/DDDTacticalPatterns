using System.Collections.Generic;
using System.Linq;

namespace DDDTacticalPatterns.DomainEvents.CoreDomain
{
    public class FakePersonRepository : IPersonRepository
    {
        private static List<Person> _persons = new List<Person>(){
        new Person()
        {
            Id = 1,
            Email = "NooriGoodarzi@gmail.com",
            FirstName = "Shahab",
            LastName = "Noori Goodarzi",
            Mobile = "09359167820",
            IsActive = true
        },
         new Person()
         {
             Id =2,
             Email = "HiradNooriGoodarzi@gmail.com",
             FirstName = "Hirad",
             LastName = "Noori Goodarzi",
             Mobile = "09357774373",
             IsActive = true
         }
        };
        public Person Get(int personId)
        {
            return _persons.FirstOrDefault(p => p.Id == personId);
        }

        public List<Person> GetAll()
        {
            return _persons;
        }
    }
}
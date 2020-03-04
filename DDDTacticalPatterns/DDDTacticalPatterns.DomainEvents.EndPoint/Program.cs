using System;
using DDDTacticalPatterns.DomainEvents.ApplicationService;
using DDDTacticalPatterns.DomainEvents.CoreDomain;

namespace DDDTacticalPatterns.DomainEvents.EndPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            var personRepository = new FakePersonRepository();

            foreach (var person in personRepository.GetAll())
            {
                Console.WriteLine($"FirstName : {person.FirstName} LastName : {person.LastName} " +
                                  $"Is Active : {person.IsActive}");
            }

            PersonDeactivatorService personDeactivation = new PersonDeactivatorService(personRepository,
                new EventDispatcher());


            personDeactivation.Execute(1);

            Console.WriteLine("After Raise Event------------------------------------------------");

            foreach (var person in personRepository.GetAll())
            {
                Console.WriteLine($"FirstName : {person.FirstName} LastName : {person.LastName} " +
                                  $"Is Active : {person.IsActive}");
            }
            Console.ReadKey();
        }
    }
}

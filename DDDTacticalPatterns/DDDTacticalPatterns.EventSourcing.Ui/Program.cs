using System;
using DDDTacticalPatterns.EventSourcingSample;

namespace DDDTacticalPatterns.EventSourcing.Ui
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonRepository personRepository = new PersonRepository();

            //WithoutVersion(personRepository);

            var person1V1 = personRepository.Get(1,1);
            var person1V2 = personRepository.Get(1,2);
            var person = personRepository.Get(1);

            Console.ReadKey();
        }

        private static void WithoutVersion(PersonRepository personRepository)
        {
            var person = personRepository.Get(1);
            var lotfi = personRepository.Get(2);
        }
    }
}

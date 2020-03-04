using System;
using DDDTacticalPatterns.Entities.CQRS;
using DDDTacticalPatterns.Entities.UsingSpec;
using DDDTacticalPatterns.Entities.Valiations;

namespace DDDTacticalPatterns.Entities.ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //FlightBookingSample();
            //SpecificationSample();
            //CqrsSample();

            Console.ReadKey();
        }

        private static void CqrsSample()
        {
            Dice dice = new Dice();
            dice.Roll();
            Console.WriteLine(dice.Value());
            Console.WriteLine(dice.Value());
            Console.WriteLine(dice.Value());
            dice.Roll();
            Console.WriteLine(dice.Value());
        }

        private static void SpecificationSample()
        {
            Person person = new Person(1, DateTime.Now.AddYears(-10));
            var allowAdult = person.AllowAdultAccess();
            Console.WriteLine($"Allow Adult =>  {allowAdult}");
        }

        private static void FlightBookingSample()
        {
            FlightBooking flightBooking = new FlightBooking(Guid.NewGuid(),
                DateTime.Now.AddDays(1), Guid.NewGuid());
            flightBooking.Reschedule(DateTime.Now.AddDays(3));
            flightBooking.Confirm();
            Console.WriteLine("Done");

            flightBooking.Reschedule(DateTime.Now.AddDays(4));
            Console.WriteLine("Done");
        }
    }
}

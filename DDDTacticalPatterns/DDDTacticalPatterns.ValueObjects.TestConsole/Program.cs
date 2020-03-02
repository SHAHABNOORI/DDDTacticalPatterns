using System;
using DDDTacticalPatterns.ValueObjects.MoneyV1;

namespace DDDTacticalPatterns.ValueObjects.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Money moneyOne = new Money(1000);
            Money moneyTwo = new Money(1000);

            Console.WriteLine(moneyOne == moneyTwo ? "Are Equal" : "Are Not Equal");

            Console.ReadKey();
        }
    }
}

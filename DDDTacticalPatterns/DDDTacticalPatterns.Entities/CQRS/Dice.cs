using System;

namespace DDDTacticalPatterns.Entities.CQRS
{
    public class Dice
    {
        private int _value;

        public void Roll()
        {
            Random r = new Random();
            _value = r.Next(0, 7);
        }
        public int Value()
        {
            return _value;
        }
    }
}
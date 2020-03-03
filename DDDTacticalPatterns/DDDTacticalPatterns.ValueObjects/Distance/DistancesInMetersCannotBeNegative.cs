using System;

namespace DDDTacticalPatterns.ValueObjects.Distance
{
    public class DistancesInMetersCannotBeNegative : Exception
    {
        public DistancesInMetersCannotBeNegative()
        {
        }

        public DistancesInMetersCannotBeNegative(string message) : base(message)
        {
        }

        public DistancesInMetersCannotBeNegative(string message, Exception innerException) : 
            base(message, innerException)
        {
        }
    }
}
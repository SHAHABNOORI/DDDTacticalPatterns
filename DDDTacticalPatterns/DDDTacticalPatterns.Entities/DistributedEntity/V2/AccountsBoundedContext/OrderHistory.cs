using System;

namespace DDDTacticalPatterns.Entities.DistributedEntity.V2.AccountsBoundedContext
{
    public class OrderHistory
    {

        public Guid CustomerId { get; private set; }
        public Orders Orders { get; private set; }

    }
}

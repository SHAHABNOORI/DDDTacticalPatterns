using System;

namespace DDDTacticalPatterns.Entities.DistributedEntity.V2.BillingBoundedContext
{
    public class PaymentDetails
    {

        public Guid CustomerId { get; private set; }
        public CardDetails Default { get; private set; }
        public CardDetails Alternate { get; private set; }

    }
}

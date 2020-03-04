using System;

namespace DDDTacticalPatterns.Entities.DistributedEntity.V2.MarketingBoundedContext
{
    public class Loyalty
    {
        public Guid CustomerId { get; private set; }
        public LoyaltySummary LoyaltySummary { get; private set; }

    }
}

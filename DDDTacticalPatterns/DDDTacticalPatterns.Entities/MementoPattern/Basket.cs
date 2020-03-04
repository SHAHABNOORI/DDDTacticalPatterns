using System;
using System.Collections.Generic;

namespace DDDTacticalPatterns.Entities.MementoPattern
{
    public class Basket
    {
        private int _id;
        private DateTime _createDate;
        private List<Product> _products;

        public void Add(Product product)
        {

        }

        public void Remove(Product product)
        {

        }

        public decimal GetTotalPrice()
        {
            return 0;
        }

        public BasketSnapshot GetSnapshot()
        {
            return new BasketSnapshot()
            {
                Id = _id,
                ProductCount = _products.Count

            };
        }
    }
}
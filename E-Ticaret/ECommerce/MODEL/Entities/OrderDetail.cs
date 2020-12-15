using CORE.CoreEntity;
using System;

namespace MODEL.Entities
{
    public class OrderDetail:EntityRepository
    {
        public Guid OrderId { get; set; }
        public Guid ProductID { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }

        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        

    }
}
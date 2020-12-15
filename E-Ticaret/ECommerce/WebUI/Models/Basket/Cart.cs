using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models.Basket
{
    public class Cart
    {
        public Cart()
        {
            Quantity = 1;
        }
        public int ID { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public string ImagePath { get; set; }
        public decimal SubTotal
        {
            get
            {
                return UnitPrice * Quantity;
            }
        }
    }
}
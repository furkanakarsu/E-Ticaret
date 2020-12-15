using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebUI.Models.Basket
{
    public class CartItem
    {
        Dictionary<int, Cart> _myBasket = new Dictionary<int, Cart>();

        public void AddProduct(Cart product)
        {
            if (_myBasket.ContainsKey(product.ID))
            {
                _myBasket[product.ID].Quantity += 1;
                return;
            }
            _myBasket.Add(product.ID, product);
        }

        public List<Cart> MyBasket
        {
            get
            {
                return _myBasket.Values.ToList();
            }
        }

    }
}
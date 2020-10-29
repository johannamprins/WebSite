using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Entities.Basket;

namespace ApplicationCore.Entities.Customer
{
    public class Order
    {

        public DateTime OrderDateTime { get; set; }
        public int OrderNo { get; set; }

        public ShoppingCartItem shoppingCartItem { get; set; }
    }
}

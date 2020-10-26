using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.Basket
{
    public class ShoppingCartItem
    {
        private int itemID { get; set; }
        public int itemQuantity { get; set; }
        public int itemPrice { get;set, }
    }
}

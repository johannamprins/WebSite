using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities.Basket
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public string ShoppingCartId { get; set; }
        public Cosmetics Cosmetics { get; set; }
        public int Amount { get; set;  }  
    }
}

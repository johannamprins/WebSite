using System;
using System.Collections.Generic;
using System.Text;
using ApplicationCore.Entities.Customer;

namespace ApplicationCore.Entities.Basket
{
    class ShoppingCart
    {

        private int ShoppingCartID;
        public DateTime dateCreated { get; set; }
        private ShoppingCartItem shoppingCartItem { get; set; }

        public virtual Account account { get; set; }


    }
}

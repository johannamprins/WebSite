﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite1.Models
{
    public class ShoppingCartItem
    {
        public  int ShoppingCartItemId { get; set; }
        public string ShoppingCartId { get; set; }
        public Item Item { get; set; }
        public decimal Price { get; set; }

    }
}
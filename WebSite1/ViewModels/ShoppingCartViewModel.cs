using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite1.Models;

namespace WebSite1.ViewModels
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}

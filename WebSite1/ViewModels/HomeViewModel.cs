using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite1.Models;

namespace WebSite1.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            ItemOnSale = new List<Item>();
        }
        public IList<Item> ItemOnSale {get; set;}
    }
}

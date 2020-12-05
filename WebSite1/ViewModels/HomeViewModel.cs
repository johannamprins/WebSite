using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite1.Models;

namespace WebSite1.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Item> ItemOnSale {get; set;}
    }
}

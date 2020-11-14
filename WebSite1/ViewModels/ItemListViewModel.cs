using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSite1.Models;

namespace WebSite1.ViewModels
{
    public class ItemListViewModel
    {
        public IEnumerable<Item> Items { get; set; }
        public string CurrentCategory { get; set; }
    }
}

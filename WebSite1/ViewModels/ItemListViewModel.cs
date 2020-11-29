using System.Collections.Generic;
using WebSite1.Models;


namespace WebSite1.ViewModels
{
    public class ItemListViewModel
    {
        public IEnumerable<Item> Items { get; set; }
        public string CurrentCategory { get; set; }
    }
}

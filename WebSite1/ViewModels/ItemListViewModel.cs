using System.Collections.Generic;
using WebSite1.Models;


namespace WebSite1.ViewModels
{
    public class ItemListViewModel
    {
        public IEnumerable<Item> Item { get; set; }
        public string CurrentCategory { get; set; }
    }
}

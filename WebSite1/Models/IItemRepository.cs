using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite1.Models
{
    public interface IItemRepository
    {
        // all items and all items that are on sale
        IEnumerable<Item> GetAllItem { get; }
        IEnumerable<Item> GetItemOnSale { get; }
        object GetAllCategories { get; set; }
        Item GetItemById(int itemId); //returns items by item id

    }
}

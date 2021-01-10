using System.Collections.Generic;

namespace WebSite1.Models
{
    public interface IItemRepository
    {
        // all items and all items that are on sale
        IEnumerable<Item> GetAllItem { get; }
        IEnumerable<Item> GetItemOnSale { get; }
        IEnumerable<Category>GetAllCategories { get; set; }
        Item GetItemById(int itemId); //returns items by item id

    }
}

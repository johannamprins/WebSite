using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace WebSite1.Models
{
    public class ItemRepository : IItemRepository
    {
        private readonly AppDbContext _appDbContext;

        public ItemRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Item> GetAllItem
        {
            get
            {
                return _appDbContext.Items.Include(c => c.Category);
            }
        }

        public IEnumerable<Item> GetItemOnSale
        {
            get
            {
                return _appDbContext.Items.Include(c => c.Category).Where(p => p.IsOnSale);
            }
        }

        public IEnumerable<Category> GetAllCategories { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public Item GetItemById(int itemId)
        {
            return _appDbContext.Items.FirstOrDefault(c => c.ItemId == itemId);
        }
    }
}

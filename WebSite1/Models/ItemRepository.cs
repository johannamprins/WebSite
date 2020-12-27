using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public IEnumerable<Item> GetAllItem => _appDbContext.Items.Include(c => c.Category);
        public IEnumerable<Item> GetItemOnSale => _appDbContext.Items.Include(c => c.Category).Where(p => p.IsOnsale);

        IEnumerable<Item> IItemRepository.GetAllItem => throw new NotImplementedException();

        IEnumerable<Item> IItemRepository.GetItemOnSale => throw new NotImplementedException();

        IEnumerable<Category> IItemRepository.GetAllCategories { get => throw new NotImplementedException(); 
            set => throw new NotImplementedException(); }

        public Item GetItemById(int itemId)
        {
            return GetAllItem.FirstOrDefault(c => c.ItemId == itemId);
            //return _appDbContext.Items.FirstOrDefault(c => c.ItemId == itemId);
        }

        Item IItemRepository.GetItemById(int itemId)
        {
            throw new NotImplementedException();
        }
    }
}

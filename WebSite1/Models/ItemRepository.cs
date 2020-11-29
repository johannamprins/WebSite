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
                return _appDbContext.Items.Include(c => c.Category).Where(p => p.IsOnsale);

            }
        }

        public IEnumerable<Item> GetItem => throw new NotImplementedException();

        public Item GetItemById(int itemId)
        {
            return _appDbContext.Items.FirstOrDefault(c => c.ItemId == itemId);
        }
    }
}



//new Item
//{
//    ItemId = 1,
//    Name = "Item 1",
//    Price = 4.55,
//    Description = "Item 1 description",
//    Category = _categoryRepository.GetAllCategories.ToList()[0],
//    ImageUrl = "https://image.shutterstock.com/image-photo/red-apple-on-white-background-260nw-158989157.jpg",
//    IsInStock = true,
//    IsOnsale = false,
//    ImageThumbnailUrl = "https://image.shutterstock.com/image-photo/red-apple-on-white-background-260nw-158989157.jpg/220px-red-apple-on-white-background-260nw-158989157.jpg"
//},
//            new Item
//            {
//                ItemId = 2,
//                Name = "Item 2",
//                Price = 4,
//                Description = "Item 2 description",
//                Category = _categoryRepository.GetAllCategories.ToList()[1],
//                ImageUrl = "https://www.kroger.com/product/images/xlarge/front/0000000004011",
//                IsInStock = true,
//                IsOnsale = false,
//                ImageThumbnailUrl = "https://www.kroger.com/product/images/xlarge/front/0000000004011"
//            },
//            new Item
//            {
//                ItemId = 3,
//                Name = "Item 3",
//                Price = 6.55,
//                Description = "Item 3 description",
//                Category = _categoryRepository.GetAllCategories.ToList()[1],
//                ImageUrl = "https://i5.walmartimages.ca/images/Enlarge/198/506/6000200198506.jpg",
//                IsInStock = true,
//                IsOnsale = false,
//                ImageThumbnailUrl = "https://i5.walmartimages.ca/images/Enlarge/198/506/6000200198506.jpg"
//            }

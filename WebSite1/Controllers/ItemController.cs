using WebSite1.Models;
using WebSite1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite1.Controllers
{
    public class ItemController : Controller
    //inherits from controller, gives us all functionality of a c
    //but is still a class
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;


        public ItemController(IItemRepository itemRepository, ICategoryRepository categoryRepository)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult List(string category)
        {
            IEnumerable<Item> items;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                items = _itemRepository.GetAllItem.OrderBy(c => c.ItemId);
                currentCategory = "All Item";
            }
            else
            {
                items = _itemRepository.GetAllItem.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)
                    ?.CategoryName;
            }

            return View(new ItemListViewModel
            {
                Item = items,
                CurrentCategory = currentCategory
            });
        }

        public IActionResult Details(int id)
        {
            var item = _itemRepository.GetItemById(id);
            if (item == null)
                return NotFound();

            return View(item);
        }


        public IActionResult AddToShoppingCart()
        {
            throw new NotImplementedException();
        }
    }
}

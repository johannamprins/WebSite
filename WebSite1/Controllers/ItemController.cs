using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebSite1.Models;
using WebSite1.ViewModels;

namespace WebSite1.Controllers
{
    public class ItemController : Controller
    //inherits from controller, gives us all functionality of a c
    //but is still a class
    {
        private readonly IItemRepository _itemRepository;
        private readonly ICategoryRepository _categoryRepository;


        public string category { get; private set; }


        public ItemController(IItemRepository itemRepository, ICategoryRepository categoryRepository)
        {
            _itemRepository = itemRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List() // builtin type for MVC, returns a view
        {
            var itemListViewModel = new ItemListViewModel();
            itemListViewModel.Items = _itemRepository.GetAllItem;
            itemListViewModel.CurrentCategory = "Bestseller";
            return View(itemListViewModel);
        }

        public IActionResult List(string category)
        {
            IEnumerable<Item> items;
            string currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                items = _itemRepository.GetAllItem.OrderBy(c => c.ItemId);
                currentCategory = "All cosmetics";
            }
            else
            {
                items = _itemRepository.GetAllItem.Where(c => c.Category.CategoryName == category);

                currentCategory = _categoryRepository.GetAllCategories.FirstOrDefault(c => c.CategoryName == category)
                    ?.CategoryName;
            }

            return View(new ItemListViewModel
            {   
                Items = items,
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

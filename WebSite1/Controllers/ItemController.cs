using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

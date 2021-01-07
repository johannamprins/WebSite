using Microsoft.AspNetCore.Mvc;
using WebSite1.Models;
using WebSite1.ViewModels;

namespace WebSite1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IItemRepository _itemRepository;

        public HomeController(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ItemOnSale = _itemRepository.GetItemOnSale
            };

            return View(homeViewModel);
        }
    }
}
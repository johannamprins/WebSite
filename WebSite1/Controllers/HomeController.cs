using Microsoft.AspNetCore.Mvc;
using WebSite1.Models;
using WebSite1.ViewModels;

namespace WebSite1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryRepository _category;

        public HomeController(ICategoryRepository category)
        {
            _category = category;
        }
        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel
            {
                ItemOnSale = (System.Collections.Generic.IEnumerable<Item>)_category.GetItemOnSale
            };
            return View(homeViewModel);
        }
    }
}
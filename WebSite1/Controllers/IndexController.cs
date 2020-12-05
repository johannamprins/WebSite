using Microsoft.AspNetCore.Mvc;

namespace WebSite1.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
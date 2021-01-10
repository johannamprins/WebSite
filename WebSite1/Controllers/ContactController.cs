using Microsoft.AspNetCore.Mvc;

namespace WebSite1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

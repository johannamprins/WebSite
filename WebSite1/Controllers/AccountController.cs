using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite1.Controllers
{
    public class AccountController : Controller
    {
        private Account _signInManager;
        private Account _userManager;

        public AccountController(Account signInManager, Account userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        // GET: /Account/Login
        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        // POST: /Account/Login

        public ActionResult Register()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
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
        private object result;

        public AccountController(Account signInManager, Account userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }
        public AccountController SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<AccountController>();
            }
            private set
            {
                _signInManager = value;
            }
        }
        public AccountController UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<AccountController>();
            }
            private set
            {
                _userManager = value;
            }
        }
        // GET: /Account/Login
        public IActionResult Login(string returnUrl)
        {
            ViewBag.ReturnUrl = returnUrl;
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        // GET: /Account/ForgotPasswordConfirmation
        [AllowAnonymous]
        public ActionResult ForgotPasswordConfirmation()
        {
            return View();
        }
        public ActionResult ResetPassword(string code)
        {
            if (code == null)
            {
                return View("Error");
            }
            return View();
        }
    }
}
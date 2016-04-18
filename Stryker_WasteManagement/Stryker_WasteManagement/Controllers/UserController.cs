using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stryker_WasteManagement.Models;
using System.Data.Entity;
using System.Web.Security;

namespace Stryker_WasteManagement.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(UserModel user)
        {
            if (ModelState.IsValid)
            {
                if (user.userName == user.password)
                {
                    FormsAuthentication.SetAuthCookie(user.userName, false);
                    return RedirectToAction("Maps");
                }
            }
            return View(user);
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LogIn");
        }

        public ActionResult Maps()
        {
            return View();

        }

       
    }
}
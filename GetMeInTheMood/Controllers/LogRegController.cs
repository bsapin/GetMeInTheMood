using GetMeInTheMood.DAL;
using GetMeInTheMood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace GetMeInTheMood.Controllers
{
    public class LogRegController : Controller
    {
        private GetMeInTheMoodContext db = new GetMeInTheMoodContext();

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LoginSubmit()
        {
            string email = Request.Form["email"];

            string password = Request.Form["password"];
            var id = -1;
            if (ModelState.IsValid)
            {
                id = findUser(email);
                User user = db.Users.Find(id);

                if(user!=null)
                {
                    if (user.password == password)
                        return RedirectToAction("Index", "Home");
                }
                else
                    return HttpNotFound();
            }
            return View("Login");
        }

        private int findUser(string email)
        {
            foreach(var user in db.Users)
            {
                if (email == user.email)
                    return user.ID;
            }
            return -1;
        }

        public ActionResult Register()
        {
            return View();
        }

       
    }
}
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
            if (ModelState.IsValid) {

                User user = db.Users.Find(email);

                if(user!=null)
                {
                    if (SHA1.Create(user.password).ToString() == password)
                        return RedirectToAction("Register");
                }
                else
                    return HttpNotFound();
            }
            return View("Login");
        }

        public ActionResult Register()
        {
            return View();
        }

       
    }
}
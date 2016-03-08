using GetMeInTheMood.DAL;
using GetMeInTheMood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
        public ActionResult Login(string email,string password)
        {
            email = GetSha256FromString(Request.Form["email"]);
            password = GetSha256FromString(Request.Form["password"]);

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
            return View();
        }

        public ActionResult Register()
        {
            return View();
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
        private static string GetSha256FromString(string strData)
        {
            var message = Encoding.ASCII.GetBytes(strData);
            SHA256Managed hashString = new SHA256Managed();
            string hex = "";

            var hashValue = hashString.ComputeHash(message);
            foreach (byte x in hashValue)
            {
                hex += String.Format("{0:x2}", x);
            }
            return hex;
        }       
    }
}
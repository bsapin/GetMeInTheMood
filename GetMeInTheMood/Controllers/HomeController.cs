using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetMeInTheMood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Moods()
        {

            return View();
        }

        public ActionResult MostPopular()
        {
            return View();
        }
    }
}
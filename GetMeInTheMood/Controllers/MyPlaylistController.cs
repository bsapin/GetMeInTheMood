using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GetMeInTheMood.Controllers
{
    public class MyPlaylistController : Controller
    {
        // GET: MyPlaylists
        public ActionResult Index()
        {
            return View();
        }
    }
}
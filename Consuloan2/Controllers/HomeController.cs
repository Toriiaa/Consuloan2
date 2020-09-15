using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Consuloan2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Title = "My ABOUT PAGE";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Title = "contact form";

            return View();
        }
        public ActionResult Services()
        {
            ViewBag.Title = "Your services page.";

            return View();
        }
    }
}
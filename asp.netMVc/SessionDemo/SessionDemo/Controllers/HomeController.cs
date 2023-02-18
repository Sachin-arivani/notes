using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SessionDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["var1"] = "This message from ViewDATA";
            ViewBag.var2 = "This message from ViewDATA";
            TempData["var3"] = "This message from ViewDATA";
            Session["var4"] = "This message from ViewDATA";
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }

    }
}
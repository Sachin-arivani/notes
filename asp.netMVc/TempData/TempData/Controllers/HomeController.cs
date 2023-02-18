using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TempData.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["message1"] = "This message from View data";
            ViewBag.message2 = "This message from View bag";
            TempData["var1"] = "This message from TEmpDATa";

            string[] games = { "cricekt", "football", "hockey" };

            TempData["sports"] = games;

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
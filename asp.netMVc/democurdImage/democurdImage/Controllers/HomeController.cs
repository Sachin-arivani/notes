using democurdImage.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace democurdImage.Controllers
{
    public class HomeController : Controller
    {
        ExampleDBEntities db = new ExampleDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Employees.ToList();
            return View(data);
        }
    }
}
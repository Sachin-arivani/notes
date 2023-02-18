using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewDataDemo.Models;

namespace ViewDataDemo.Controllers
{
    public class HomeController : Controller
    {
        public object ViewDate { get; private set; }

        // GET: Home
        public ActionResult Index()
        {
            ViewData["message"] = "This is message form view data";
            ViewData["CurrentTime"] = DateTime.Now.ToLongTimeString();

            string[] fruits = { "apple","Banana","orange","coconut"};

            ViewData["fal"] = fruits;

            ViewData["sprotsTools"] = new List<string>()
            {
                "cricket",
                "hockey",
                "football"
            };


            Employee Emp = new Employee();
            Emp.EmpId = 11;
            Emp.EmpName = "Dharmesh";
            Emp.EmpDesignation = "Coder";

            ViewData["Employee"] = Emp;

          

            return View();
        }
    }
}
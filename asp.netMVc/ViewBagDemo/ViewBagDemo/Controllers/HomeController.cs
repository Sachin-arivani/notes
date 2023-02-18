using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ViewBagDemo.Models;

namespace ViewBagDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Message = "Message from viewbag";
            ViewBag.CurrentDate =DateTime.Now.ToLongDateString();

            string[] fruits = { "Apple","orange","Banana"};
            ViewBag.fal = fruits;

            ViewBag.sportsList = new List<string>()
            {
                "cricket",
                "Football",
                "BasketBall"
            };

            Employee Emp = new Employee();
            Emp.EmpId = 10;
            Emp.EmpName = "Rohit";
            Emp.EmpAddress = "Gorakhpur";

            ViewBag.Employee = Emp;

            

            return View();
        }
    }
}
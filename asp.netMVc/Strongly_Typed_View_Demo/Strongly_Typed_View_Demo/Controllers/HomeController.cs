using Strongly_Typed_View_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Strongly_Typed_View_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            Employee emp1 = new Employee();
            emp1.Id = 20;
            emp1.Name = "Raghav";
            emp1.Age = 29;

            Employee emp2 = new Employee();
            emp2.Id = 20;
            emp2.Name = "Raghav";
            emp2.Age = 29;

            Employee emp3 = new Employee();
            emp3.Id = 20;
            emp3.Name = "Raghav";
            emp3.Age = 29;

            List<Employee> employeedet = new List<Employee>();
            employeedet.Add(emp1);
            employeedet.Add(emp2);
            employeedet.Add(emp3);

            //ViewData["var1"] = emp1;
            //ViewBag.var2 = emp1;


            return View(employeedet);
        }
    }
}
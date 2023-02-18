using AjaxMVCLoadMore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxMVCLoadMore.Controllers
{
    public class HomeController : Controller
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        // GET: Home
        public ActionResult Index()
        {
            int num = 2;
            Session["data"] = num;
            var data = db.employee_details.ToList().Take(num);
            return View(data);
        }

        [HttpPost]
        public ActionResult Index(employee_details e) 
        {
            int rows = Convert.ToInt32(Session["data"]) + 2;
            var data = db.employee_details.ToList().Take(rows);
            Session["Data"] = rows;
            return PartialView("_EmpData",data);
        }
    }
}
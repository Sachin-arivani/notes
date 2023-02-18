using jQueryDataTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jQueryDataTable.Controllers
{
    public class HomeController : Controller
    {
        Employee3DBEntities db = new Employee3DBEntities();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.employee_details.ToList();
            return View(data);
        }
    }
}
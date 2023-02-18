using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using view_Bag.Models;

namespace view_Bag.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(Emp_md emp_md)
        {
            ViewBag.message = "Hello this is view bag";
            ViewBag.current_Date = DateTime.Now.ToLongDateString();
            string[] fruits = {"Apple","Banana","Orange"};
            ViewBag.fruits_Array=fruits;

            ViewBag.sport_List = new List<string>()
            { 
              "Cricket",
              "Footbal",
              "Hockey",
              "Hockey"

            };
            Emp_md model = new Emp_md();

            model.Emp_id = 22;
            model.EmpName = "sudheer";
            model.Emp_designation = "coder";

            ViewBag.emplo = model;



            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
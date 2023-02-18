using newWebAPIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace newWebAPIDemo.Controllers
{
    public class ConsumeController : Controller
    {
        // GET: Consume
        HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            List<employee_details> list = new List<employee_details>();
            client.BaseAddress = new Uri("http://localhost:55318/api/newAPI");
            var response =client.GetAsync("newAPI");
            response.Wait();

            var test = response.Result;

            if(test.IsSuccessStatusCode)
            {
                var display =test.Content.ReadAsAsync<List<employee_details>>();
                display.Wait();
                list = display.Result;
            }
            return View(list);
        }
    }
}
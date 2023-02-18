using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using web_api_crud.Models;

namespace web_api_crud.Controllers
{
    public class mvcCurdController : Controller
    {
        // GET: mvcCurd
        HttpClient client = new HttpClient();

        public ActionResult Index()
        {
            List<Employee> emp_list = new List<Employee>();
            client.BaseAddress = new Uri("http://localhost:54510/api/crudAPI");
            var response = client.GetAsync("curdAPI");
            response.Wait();

            var test = response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<Employee>>();
                display.Wait();
                emp_list = display.Result;
            }

            return View(emp_list);
        }
    }
}
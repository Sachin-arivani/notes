using prac_api_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace prac_api_demo.Controllers
{
    public class CurdMVCController : Controller
    {
        // GET: CurdMVC

        HttpClient client = new HttpClient();
        public ActionResult Index()
        {
            List<Employee> emp_list = new List<Employee>();
            client.BaseAddress = new Uri("http://localhost:55033/api/CurdAPI");
            var response = client.GetAsync("CurdAPI");
            response.Wait();

            var test = response.Result;

            if(test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<Employee>>();
                display.Wait();

                emp_list = display.Result;
            }
            return View(emp_list);
        }

        public ActionResult Create()
        {
           return View();
        }

        [HttpPost]

        public ActionResult Create(Employee emp)
        {

            client.BaseAddress = new Uri("http://localhost:55033/api/CurdAPI");
            var response = client.PostAsJsonAsync<Employee>("CurdAPI",emp);
            response.Wait();

            var test = response.Result;

            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View("Create");
        }

        public ActionResult Details(int id)
        {
            Employee e = null;

            client.BaseAddress = new Uri("http://localhost:55033/api/CurdAPI");
            var response = client.GetAsync("CurdAPI?id="+ id.ToString());
            response.Wait();

            var test = response.Result;

            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Employee>();
                display.Wait();
                e = display.Result;
            }
            return View(e);
        }


        public ActionResult Edit(int id)
        {
            Employee e = null;

            client.BaseAddress = new Uri("http://localhost:55033/api/CurdAPI");
            var response = client.GetAsync("CurdAPI?id=" + id.ToString());
            response.Wait();

            var test = response.Result;

            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Employee>();
                display.Wait();
                e = display.Result;
            }
            return View(e);
        }

        [HttpPost]

        public ActionResult Edit(Employee e)
        {

            client.BaseAddress = new Uri("http://localhost:55033/api/CurdAPI");
            var response = client.PutAsJsonAsync<Employee>("CurdAPI", e);
            response.Wait();

            var test = response.Result;

            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View("Edit");
        }

        public ActionResult Delete(int id)
        {
            Employee e = null;

            client.BaseAddress = new Uri("http://localhost:55033/api/CurdAPI");
            var response = client.GetAsync("CurdAPI?id=" + id.ToString());
            response.Wait();

            var test = response.Result;

            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<Employee>();
                display.Wait();
                e = display.Result;
            }
            return View(e);
        }

        [HttpPost,ActionName("Delete")]

        public ActionResult DeleteConfirm(int id)
        {

            client.BaseAddress = new Uri("http://localhost:55033/api/CurdAPI");
            var response = client.DeleteAsync("CurdAPI/"+id.ToString());
            response.Wait();

            var test = response.Result;

            if (test.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }

            return View("Delete");
        }
    }
}
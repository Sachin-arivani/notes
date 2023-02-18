using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using web_api_crud.Models;

namespace web_api_crud.Controllers
{
    public class crudAPIController : ApiController
    {
        web_api_curd_DBEntities db = new web_api_curd_DBEntities();

        [System.Web.Http.HttpGet]
        public IHttpActionResult GetEmployees()
        {
            List<Employee> list = db.Employees.ToList();
            return Ok(list);
        }

       
    }
}

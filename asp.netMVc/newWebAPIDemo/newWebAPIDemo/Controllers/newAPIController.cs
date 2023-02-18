using newWebAPIDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace newWebAPIDemo.Controllers
{
    public class newAPIController : ApiController
    {
        EmployeeDBEntities db = new EmployeeDBEntities();
        [System.Web.Http.HttpGet]
        public IHttpActionResult Action()
        {
            List<employee_details> obj = db.employee_details.ToList();
            return Ok(obj);
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult Action(int id)
        {
            var obj = db.employee_details.Where( model => model.id == id).FirstOrDefault();
            return Ok(obj);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ApiMVCDemo1.Controllers
{
    public class EmployeesDataController : ApiController
    {
        public string[] myEmployee = { "Rohan", "Subham", "Gautam", "Arvind" };
        [HttpGet]

        public string[] getEmployee()
        {
            return myEmployee;
        }
        //[HttpGet]
        //public string[] getEmployeeByIndex(int id)
        //{
        //    return myEmployee[id];
        //}
    }
}

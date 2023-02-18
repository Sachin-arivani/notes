﻿using DataAnotation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataAnotation.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Employee e)
        {
            if (ModelState.IsValid==true)
            {
                ViewData["successMessage"]= "<script>alert('Data has been submitted')</script>";
                ModelState.Clear();
            }
            return View();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace Validation_Message_summary.Controllers
{
    public class HomeController : Controller
    {
        string EmailPattern = " ^[a - zA - Z0 - 9 + _.-] +@[a-zA-Z0-9.-]+$";

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string FullName, string Age, string Email)
        {
            if(FullName.Equals("")==true)
            {
                ModelState.AddModelError("FullName", "Full Name is medetory !!");
                ViewData["fullNameError"]= "*";
            }

            if (Age.Equals("") == true)
            {
                ModelState.AddModelError("Age", "Age is medetory !!");
                ViewData["AgeError"] = "*";
            }

            if (Email.Equals("") == true)
            {
                ModelState.AddModelError("Email", "Email is medetory !!");
                ViewData["EmailError"] = "*";
            }
            else
            {
                if(Regex.IsMatch(Email,EmailPattern)== false)
                {
                    ModelState.AddModelError("Email", "Invalid Email !!");
                    ViewData["EmailError"] = "*";
                }
            }


            if (ModelState.IsValid == true)
            {
                ViewData["SuccessMessage"] = "<script>alert('Data has been submited !!')</script>";
                ModelState.Clear();
            }
            return View();
        }
    }
}
using signuplogindemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace signuplogindemo.Controllers
{
    public class LoginController : Controller
    {
        signUpnewDemoEntities db = new signUpnewDemoEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(user u)
        {
            var user = db.users.Where(model => model.username == u.username && model.password == u.password).FirstOrDefault();
            if (user != null)
            {
                Session["userId"] = u.id.ToString();
                Session["username"] = u.username.ToString();
                TempData["LoginSuccessMessage"] = "<script>alert('Login Successfully !!')</script>";
                return RedirectToAction("Index", "User");
            }
            else
            {
                ViewBag.ErrorMessage = "<script>alert('User Name or Password is incorrect !!')</script>";
                return View();
            }

        }

        public ActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Signup(user u)
        {
            if (ModelState.IsValid == true)
            {
                db.users.Add(u);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    ViewBag.InserMessage = "<script>alert('Registered Successfully !!')</script>";
                    ModelState.Clear();
                }
                else
                {
                    ViewBag.InserMessage = "<script>alert('Registered Failed !!')</script>";
                }
            }

            return View();
        }
    }
}
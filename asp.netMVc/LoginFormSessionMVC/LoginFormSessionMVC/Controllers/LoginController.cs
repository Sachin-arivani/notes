using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginFormSessionMVC.Models;

namespace LoginFormSessionMVC.Controllers
{
    public class LoginController : Controller
    {
        LoginDBEntities db = new LoginDBEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(user s)
        {
            if(ModelState.IsValid== true)
            {
                var credentials = db.users.Where(model => model.UserName == s.UserName && model.Password == s.Password).FirstOrDefault();
                if(credentials==null)
                {
                    ViewBag.ErrorMessage = "Login Faild";
                    return View();
                }
                else
                {
                    Session["username"] = s.UserName;
                    return RedirectToAction("Index","Home");
                }
            }
            return View();
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index","Login");
        }

        public ActionResult Reset()
        {
            ModelState.Clear();
            return RedirectToAction("Index", "Login");
        }
    }
}
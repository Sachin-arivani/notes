using EFCodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFCodeFirstApproach.Controllers
{
    public class HomeController : Controller
    {
        StudentContext db = new StudentContext();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.Students.ToList();
            return View(data);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student s)
        {
            db.Students.Add(s);
            int a = db.SaveChanges();
            if(ModelState.IsValid==true)
            {
                if (a > 0)
                {
                    //ViewBag.InsertMessage = "<script>alert('Data Inserted !!')</script>";
                    //TempData["InsertMessage"] = "<script>alert('Data Inserted !!')</script>";
                    TempData["InsertMessage"] = "Data Inserted !!";
                    return RedirectToAction("Index");
                    //ModelState.Clear();
                }
                else
                {
                    ViewBag.InsertMessage = "<script>alert('Data Not Inserted !!')</script>";
                }
            }
            
            return View();
        }

        public ActionResult Edit(int id)
        {
            var row = db.Students.Where(model => model.Id==id).FirstOrDefault();

            return View(row);
        }

        [HttpPost]

        public ActionResult Edit(Student s)
        {
            if(ModelState.IsValid==true)
            {
                db.Entry(s).State = EntityState.Modified;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    //ViewBag.UpdateMessage = "<script>alert('Data is Update !!')</script>";
                    //ModelState.Clear();
                    //TempData["UpdateMessage"] = "<script>alert('Data is Update !!')</script>";
                    TempData["UpdateMessage"] = "Data is Update !!";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.UpdateMessage = "<script>alert('Data is Not Update !!')</script>";
                }
            }
            
            return View();
        }



        public ActionResult Delete(int id)
        {
            var StudfentIdRow = db.Students.Where(model => model.Id == id).FirstOrDefault();

            return View(StudfentIdRow);
        }

        [HttpPost]

        public ActionResult Delete(Student s)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(s).State = EntityState.Deleted;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    //ViewBag.UpdateMessage = "<script>alert('Data is Update !!')</script>";
                    //ModelState.Clear();
                    //TempData["DeleteMessage"] = "<script>alert('Data is Deleted !!')</script>";
                    TempData["DeleteMessage"] = "Data is Deleted !!";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["DeleteMessage"] = "Data is not Deleted !!";
                    //TempData["DeleteMessage"] = "<script>alert('Data is Deleted !!')</script>";
                    //ViewBag.DeleteMessage = "<script>alert('Data is Not Update !!')</script>";
                }
            }

            return View();
        }

        public ActionResult Details(int id)
        {
            var DetailsById = db.Students.Where(model => model.Id == id).FirstOrDefault();
            return View(DetailsById);
        }
    }   
}
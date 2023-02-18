using DataBaseFirstApproachEF2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataBaseFirstApproachEF2.Controllers
{
   
    public class HomeController : Controller
    {
        DatabaseFirstEFEntities db = new DatabaseFirstEFEntities();
        // GET: Home
        public ActionResult Index()
        {
            var data = db.students.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(student s)
        {
            if(ModelState.IsValid==true)
            {
                db.students.Add(s);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["InsertMessage"] = "<script>alert('Data Inserted !!')</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["InsertMessage"] = "<script>alert('Data Not Inserted !!')</script>";
                }
               
            }
            return View();

        }



        public ActionResult Edit(int id)
        {
            var row = db.students.Where(model => model.Id == id).FirstOrDefault();
            return View(row);
        }

        [HttpPost]
        public ActionResult Edit(student s)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(s).State = EntityState.Modified;

                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["UpdateMessage"] = "<script>alert('Data Updated Inserted !!')</script>";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["UpdateMessage"] = "<script>alert('Data Not Update Inserted !!')</script>";
                }
            }

            return View();
        }

        public ActionResult Delete(int id)
        {
            if(id > 0)
            {
                var Deleterow = db.students.Where(model => model.Id == id).FirstOrDefault();
                if(Deleterow !=null)
                {
                    db.Entry(Deleterow).State = EntityState.Deleted;

                    int a = db.SaveChanges();
                    if (a > 0)
                    {
                        TempData["deletemessage"] = "<script>alert('data is deleted !!')</script>";
                        return RedirectToAction("index");
                    }
                    else
                    {
                        TempData["deletemessage"] = "<script>alert('data is not deleted !!')</script>";
                    }

                }



            }
            
            return View();
        }

        public ActionResult Details(int id)
        {
            var row = db.students.Where(model => model.Id == id).FirstOrDefault();
            return View(row);
        }

        //[HttpPost]

        //public ActionResult Delete(student s)
        //{

        //        db.Entry(s).State = EntityState.Deleted;

        //        int a = db.SaveChanges();
        //        if (a > 0)
        //        {
        //            TempData["DeleteMessage"] = "<script>alert('Data is Deleted !!')</script>";
        //            return RedirectToAction("Index");
        //        }
        //        else
        //        {
        //            TempData["DeleteMessage"] = "<script>alert('Data is not Deleted !!')</script>";
        //        }


        //    return View();
        //}
    }
}
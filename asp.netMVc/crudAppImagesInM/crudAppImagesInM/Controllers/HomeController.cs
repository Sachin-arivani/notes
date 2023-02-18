using crudAppImagesInM.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace crudAppImagesInM.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        ExampleDBEntities db = new ExampleDBEntities();
        public ActionResult Index()
        {
            var data = db.Employees.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
           
            return View();
        }

        [HttpPost]

        public ActionResult Create(Employee e)
        {
             if(ModelState.IsValid==true)
            {
                string fileName = Path.GetFileNameWithoutExtension(e.ImageFile.FileName);
                string extension = Path.GetExtension(e.ImageFile.FileName);
                HttpPostedFileBase postedFile = e.ImageFile;
                int length = postedFile.ContentLength;
                
                if (extension.ToLower() ==".jpg" || extension.ToLower() == ".jpeg" || extension.ToLower() == ".png")
                {
                    if(length<=1000000)
                    {
                        fileName = fileName + extension;
                        e.image_path = "~/images/" + fileName;
                        fileName = Path.Combine(Server.MapPath("~/images/", fileName));
                        e.ImageFile.SaveAs(fileName);
                        db.Employees.Add(e);
                        int a  = db.SaveChanges();
                        if(a>0)
                        {
                            TempData["CreateMessage"] = "<script>alert('Data inserted successfully!!')</script>";
                            ModelState.Clear();
                            return RedirectToAction("Index","Home");
                        }
                        else
                        {
                            TempData["CreateMessage"] = "<script>alert('Data inserted not successfully!!')</script>";
                        }
                    }
                    else
                    {
                        TempData["sizeMessage"] = "<script>alert('Image size should less then 1mb!!')</script>";
                    }
                }
                else
                {
                    TempData["extensionMessage"]="<script>alert('Format Not Support!!')</script>";
                }
            }
            return View();
        }

        public ActionResult Edit(int id)
        {
            var EmployeeRow = db.Employees.Where(model => model.id == id).FirstOrDefault();
            Session["image"] = EmployeeRow.image_path;
            return View(EmployeeRow);
        }

        [HttpPost]

        public ActionResult Edit(Employee e)
        {
           if(ModelState.IsValid==true)
            {
                string fileName = Path.GetFileNameWithoutExtension(e.ImageFile.FileName);
                string extension = Path.GetExtension(e.ImageFile.FileName);
                HttpPostedFileBase postedFile = e.ImageFile;
                int length = postedFile.ContentLength;

                if (extension.ToLower() == ".jpg" || extension.ToLower() == ".jpeg" || extension.ToLower() == ".png")
                {
                    if (length <= 1000000)
                    {
                        fileName = fileName + extension;
                        e.image_path = "~/images/" + fileName;
                        fileName = Path.Combine(Server.MapPath("~/images/", fileName));
                        e.ImageFile.SaveAs(fileName);
                        db.Entry(e).State = EntityState.Modified;
                        int a = db.SaveChanges();
                        if (a > 0)
                        {
                            string ImagePath = Request.MapPath(Session["Image"].ToString());
                            if (System.IO.File.Exists(ImagePath))
                            {
                                System.IO.File.Delete(ImagePath);
                            }

                            TempData["UpdateMessage"] = "<script>alert('Data Updated successfully!!')</script>";
                            ModelState.Clear();
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            TempData["UpdateMessage"] = "<script>alert('Data inserted not successfully!!')</script>";
                        }
                    }
                    else
                    {
                        TempData["sizeMessage"] = "<script>alert('Image size should less then 1mb!!')</script>";
                    }
                }
                else
                {
                    TempData["extensionMessage"] = "<script>alert('Format Not Support!!')</script>";
                }
            }
           else
            {
                e.image_path = Session["Image"].ToString();
                db.Entry(e).State = EntityState.Modified;
                int a = db.SaveChanges();
                if (a > 0)
                {
                    TempData["UpdateMessage"] = "<script>alert('Data Updated successfully!!')</script>";
                    ModelState.Clear();
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    TempData["UpdateMessage"] = "<script>alert('Data inserted not successfully!!')</script>";
                }
            }
            return View();
        }
        public ActionResult Delete(int id)
        {
            if(id>0)
            {
                var EmployeeRow =db.Employees.Where(model =>model.id==id).FirstOrDefault();
                if(EmployeeRow !=null)
                {
                    db.Entry(EmployeeRow).State=EntityState.Deleted;
                    int a =db.SaveChanges();
                    if(a > 0)
                    {
                        TempData["DeleteMessage"] = "<script>alert('Data Deleted  successfully!!')</script>";
                        string ImagePath = Request.MapPath(EmployeeRow.image_path.ToString());
                        if(System.IO.File.Exists(ImagePath))
                        {
                            System.IO.File.Delete(ImagePath);
                        }
                    }
                    else
                    {
                        TempData["DeleteMessage"] = "<script>alert('Data Not Deleted  successfully!!')</script>";
                    }
                }
            }
            return RedirectToAction("Index","Home");
        }

        public ActionResult Details(int id)
        {
            var EmployeeRow = db.Employees.Where(model =>model.id == id);
            Session["Image2"] = EmployeeRow.image_path.ToString();
            return View(EmployeeRow);
        }
    }
}
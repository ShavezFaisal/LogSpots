using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LogSpots.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult upload()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult upload(HttpPostedFileBase file)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    //Method 1 Get file details from current request    
                    //Uncomment following code if you wants to use method 1    
                    //if (Request.Files.Count > 0)    
                    // {    
                    //     var Inputfile = Request.Files[0];    

                    //     if (Inputfile != null && Inputfile.ContentLength > 0)    
                    //     {    
                    //         var filename = Path.GetFileName(Inputfile.FileName);    
                    //       var path = Path.Combine(Server.MapPath("~/uploadedfile/"), filename);    
                    //        Inputfile.SaveAs(path);    
                    //    }    
                    // }    

                    //Method 2 Get file details from HttpPostedFileBase class    

                    if (file != null)
                    {
                        string path = Path.Combine(Server.MapPath("~/UploadedVideos"), Path.GetFileName(file.FileName));
                        file.SaveAs(path);

                    }
                    ViewBag.FileStatus = "File uploaded successfully.";
                }
                catch (Exception)
                {

                    ViewBag.FileStatus = "Error while file uploading.";
                }

            }
            return View("upload");
        }
    }
}
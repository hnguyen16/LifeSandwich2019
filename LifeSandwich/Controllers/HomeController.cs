using LifeSandwich.Models;
using LifeSandwich.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeSandwich.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            string[] files = System.IO.Directory.GetFiles(Server.MapPath("~/content/Images"));

            IndexViewModel indexVM = new IndexViewModel();

            foreach (string f in files)
            {
                Image pic = new Image();
                string fileName =  f.Split('\\').Last();
                pic.name = fileName.Split('.').First();
                pic.filePath = "~/Content/Images/" + fileName; 
                indexVM.images.Add(pic);
            }
            return View(indexVM);
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
    }
}
using LifeSandwich.Models;
using LifeSandwich.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeSandwich.Controllers
{
    public class ImageController : Controller
    {
        ImageRepository repository = new ImageRepository();
        // GET: Image
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost()]
        public ActionResult Add(Image image)
        {
            repository.Add(image);
            repository.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
using LifeSandwich.Models;
using LifeSandwich.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LifeSandwich.Controllers
{
    public class CollectionController : Controller
    {
        ImageCollectionDBContext context = new ImageCollectionDBContext();
        //CollectionRepository repository = new CollectionRepository();

        // GET: Collection
        public ActionResult List()
        {
            var  collections = context.Collections.ToList();
            return View(collections);
        }

        public ActionResult Create()
        {

            var name= System.Web.HttpContext.Current.Request["name"];

            if (!string.IsNullOrEmpty(name))
            {
                var c = new Collection();
                c.Name = name;

                context.Collections.Add(c);
                context.SaveChanges();

                return RedirectToAction("List");
            }
            return View();
        }

        public ActionResult Delete(string name)
        {
            var collection = context.Collections.SingleOrDefault(x => x.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            context.Collections.Remove(collection);
            context.SaveChanges();            

            return RedirectToAction("List");
        }

        public ActionResult Details(int id)
        {
            
            var collection = context.Collections.SingleOrDefault(x => x.CollectionID == id);
            List<Image> images = new List<Image>();
            if (collection != null && collection.Images?.Count > 0)
            {
                images = collection.Images.ToList();
            }

            return View(images);
        }

        public ActionResult AddImage()
        {
            Image image = new Image();

            //context.Collections.Add(image);


            return View("Details");
        }
    }
}
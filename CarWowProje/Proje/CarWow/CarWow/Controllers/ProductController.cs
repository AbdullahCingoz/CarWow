using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarWow.Models;

namespace CarWow.Controllers
{
    public class ProductController : Controller
    {
        CarWowDb db = new CarWowDb();
        
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }
            Product p = db.Products.Find(id);
            return View(p);
        }
        
      
    }
}
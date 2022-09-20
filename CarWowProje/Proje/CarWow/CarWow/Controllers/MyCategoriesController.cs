using CarWow.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarWow.Controllers
{
    public class MyCategoriesController : Controller
    {
       CarWowDb db =new CarWowDb();
        // GET: MyCategories
        public ActionResult Index()
        {
            List<Category> categoryList = db.Categories.Where(x => x.Status == true).ToList();
            return View(categoryList);
        }
        public ActionResult kategoriDetay(int id)
        {
            List<Product> categoris = db.Products.Where(x => x.Category.ID == id).ToList();
            return View(categoris);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarWow.Models;

namespace CarWow.Controllers
{
    public class HomeController : Controller
    {
        CarWowDb db = new CarWowDb();
        // GET: Home
        public ActionResult Index()
        {
            List<Product> ProductList = db.Products.Where(s => s.SellStatus == true).ToList();
            return View(ProductList);
        }
    }
}
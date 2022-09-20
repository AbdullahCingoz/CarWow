using FriendyolTicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FriendyolTicaret.Controllers
{
    public class HomeController : Controller
    {
        dbModel db = new dbModel();
        // GET: Home
        public ActionResult Index()
        {
            List<Product> ProductList = db.Products.Where(s => s.SellStatus == true).ToList();
            return View(ProductList);
        }
    }
}
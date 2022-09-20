using FriendyolTicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FriendyolTicaret.Controllers
{
    public class ProductController : Controller
    {
        dbModel db = new dbModel();
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int? id)
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
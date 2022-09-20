using CarWow.Models;
using CarWow.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;




namespace CarWow.Controllers
{
    public class UserController : Controller
    {
        CarWowDb db=new CarWowDb();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                User u = db.Users.FirstOrDefault(x => x.Mail == model.Mail && x.Password == model.Password);
                if (u != null)
                {
                    Session["user"] = u;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }
        [HttpGet]
        public ActionResult SingUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SingUp(User user)
        {
            if (ModelState.IsValid)
            {

                user.CreationDate = DateTime.Now;
                user.Status = true;
                db.Users.Add(user);

                db.SaveChanges();
                return RedirectToAction("Login");
            }
            return View(user);
        }
        public ActionResult LogOut()
        {
            Session.Remove("user");
            return RedirectToAction("Index", "Home"); 
        }

      
      
    }
}
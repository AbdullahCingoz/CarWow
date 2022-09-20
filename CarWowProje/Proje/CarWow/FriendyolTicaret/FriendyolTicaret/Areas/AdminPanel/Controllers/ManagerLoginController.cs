using FriendyolTicaret.Areas.AdminPanel.Model.ViewModel;
using FriendyolTicaret.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FriendyolTicaret.Areas.AdminPanel.Controllers
{
    public class ManagerLoginController : Controller
    {
        dbModel db = new dbModel();
        // GET: AdminPanel/ManagerLogin
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(AdminLoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (db.Managers.Count(x => x.Mail == model.Mail && x.Password == model.Password) > 0)
                {
                    Manager m = db.Managers.FirstOrDefault(x => x.Mail == model.Mail && x.Password == model.Password);
                    Session["manager"] = m;
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }
    }
}
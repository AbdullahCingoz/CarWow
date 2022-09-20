using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarWow.Areas.AdminPanel.Filters;
using CarWow.Models;

namespace CarWow.Areas.AdminPanel.Controllers
{
    [AdminAuthenticationFilter]
    public class BrandController : Controller
    {
        CarWowDb db=new CarWowDb();
        // GET: AdminPanel/Brand
        public ActionResult Index()
        {
            List<Brand>brands=db.Brands.ToList();
            return View(brands);
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return RedirectToAction("Index");
            }
            Brand brand = db.Brands.Find(id);
            if (brand == null)
            {
                //return HttpNotFound();
                return RedirectToAction("Index");
            }
            return View(brand);
        }

        // GET: AdminPanel/Brand/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminPanel/Brand/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,status")] Brand brand)
        {
            if (ModelState.IsValid)
            {
                db.Brands.Add(brand);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(brand);
        }

        // GET: AdminPanel/Brand/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                //return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                return RedirectToAction("Index");
            }
            Brand brand = db.Brands.Find(id);
            if (brand == null)
            {
                //return HttpNotFound();
                return RedirectToAction("Index");
            }
            return View(brand);
        }

      
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,status")] Brand brand)
        {
            if (ModelState.IsValid)
            {
                db.Entry(brand).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(brand);
        }

        // GET: AdminPanel/Brand/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Brand b = db.Brands.Find(id);
            b.status = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Models;

namespace Capstone.Controllers
{
    public class ProductController : Controller
    {
        private ProductEntities db = new ProductEntities();

        //
        // GET: /Product/

        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        //
        // GET: /Product/Details/5

        public ActionResult Details(int id = 0)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        //
        // GET: /Product/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Product/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Products.Add(product);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(product);
        }

        //
        // GET: /Product/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        //
        // POST: /Product/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                db.Entry(product).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(product);
        }

        //
        // GET: /Product/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        //
        // POST: /Product/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Product product = db.Products.Find(id);
            db.Products.Remove(product);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }

        private ProductEntities pe = new ProductEntities();
        public ActionResult Products(int category_ID)
        {
            if (ModelState.IsValid)
            {
                using (ProductEntities pd = new ProductEntities())
                {
                    Product productData = new Product();
                    var product = pd.Products.ToList();
                    if (product != null)
                    {
                        ViewBag.productData = product;
                        return View();
                    }
                }
            }
            return View();
        }
    }
}
using System;
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
                using (ProductEntities context = new ProductEntities())
                {
                    Product productData = new Product();
                    //this will allow you to query for the selected category ID
                    var product = context.Products.Where(table => table.category_ID == category_ID).ToList();
                    if (product != null)
                    {
                        ViewBag.productData = product;
                        return View();
                    }
                }
            }
            return View();
        }

        
        ProductEntities qEntity = new ProductEntities();

        public ActionResult ProductView(int product_ID) 
        {
            ViewBag.ProductRow = qEntity.Products.Where(x => x.product_ID == product_ID).ToList();
            ViewBag.quantity = ViewBag.ProductRow[0].quantity;
            ViewBag.quantity++;

            using (ProductEntities context = new ProductEntities())
            {
                Product productData = new Product();
                //this will allow you to query for the selected category ID
                var product = context.Products.Where(table => table.product_ID == product_ID).ToList();
                if (product != null)
                {
                    ViewBag.productImage = product[0].image;
                    ViewBag.productPrice = product[0].price;
                    ViewBag.productName = product[0].name;
                    ViewBag.productStarus = product[0].productStatus_ID;
                    ViewBag.productDescription = product[0].description;
                    ViewBag.product_ID = product[0].product_ID;
                    ViewBag.category_ID = product[0].category_ID;
                    int category_ID = product[0].category_ID;
                }
            }
            return View();
        }
        public ActionResult AddToCart(int product_ID) 
        {

          return RedirectToAction("OrderNow", "ShoppingCart", new { product_id = product_ID });
        }
    }
}
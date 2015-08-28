using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.Controllers
{
    public class CheckoutController : Controller
    {
        //
        // GET: /Checkout/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Checkout()
        {
            return View();
        }
        private int isExisting(int product_id)
        {
            List<Item> cart = (List<Item>)Session["cart"];
            for (int i = 0; i < cart.Count; i++)

                if (cart[i].Pr.product_ID == product_id)
                    return i;
            return -1;

        }
        public ActionResult Delete(int product_id, int category_id)
        {
            int index = isExisting(product_id);
            List<Item> cart = (List<Item>)Session["cart"];
            cart.RemoveAt(index);
            Session["cart"] = cart;
            return RedirectToAction("Checkout", "Checkout", new { category_ID = category_id });
        }
    }
}
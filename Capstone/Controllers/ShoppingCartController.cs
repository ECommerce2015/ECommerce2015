using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Models;

namespace Capstone.Controllers
{
    public class ShoppingCartController : Controller
    {
        private ProductEntities pe = new ProductEntities();

        public ActionResult Index()
        {
            return View();
        }

        private int isExisting(int product_id) 
        {
            List<Item> cart = (List <Item>) Session["cart"];
            for (int i = 0; i < cart.Count; i++)

                if (cart[i].Pr.product_ID == product_id)
                    return i;
                return -1;
            
        }

        public ActionResult OrderNow(int product_id,int category_id)
        {
            if (Session["cart"] == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item(pe.Products.Find(product_id), 1));
                Session["cart"] = cart;
            }
            else 
            {
                List<Item> cart = (List<Item>)Session["cart"];
                int index = isExisting(product_id);
                
                if (index == -1)
                {
                    cart.Add(new Item(pe.Products.Find(product_id), 1));
                }
                else 
                {
                    cart[index].Quantity++;
                    cart[index].Pr.price = cart[index].Price * cart[index].Quantity;
                  
                }
                Session["cart"] = cart;
            }
            return RedirectToAction("Products", "Product", new { category_ID = category_id });
        }
    }
}

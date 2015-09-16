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
        private ShippingMethodsEntities shippingMethod = new ShippingMethodsEntities(); 

        public ActionResult Index()
        {
            if (Session["customerID"]==null) 
            {
                RedirectToAction("Index", "Registration");
            }
            return View();
        }

        StateEntities sEntity = new StateEntities();
        public ActionResult Checkout()
        {
            ViewBag.StatesList = sEntity.States.ToList();
            ViewBag.listShippingMethod = shippingMethod.ShippingMethods.ToList();
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
        public ActionResult ProcessCheckout(int customerID, ShippingAddress shippingaddress,ShippingMethod shippingMethod,CustomerBilling customerBilling) 
        {
            try
            {
                using (ShippingAddressEntities shippingEntities = new ShippingAddressEntities()) 
                {
                    CustomerAddressEntities cAddentity = new CustomerAddressEntities();
                    List<CustomerAddress> customeraddress = cAddentity.CustomerAddresses.Where(x => x.customerAddress_ID == customerID).ToList();
                    shippingaddress.customer_ID = customeraddress[0].customerAddress_ID;
                    shippingaddress.CustomerAddress_ID = customeraddress[0].customerAddress_ID;
                    shippingaddress.shippingMethod_ID = shippingMethod.shippingMethod_ID;
                    shippingEntities.ShippingAddresses.Add(shippingaddress);
                    shippingEntities.SaveChanges();
                }
                using(CustomerBillingEntities customerBillingentity = new CustomerBillingEntities())
                {
                    customerBilling.customer_ID = customerID;
                    customerBillingentity.CustomerBillings.Add(customerBilling);
                    customerBillingentity.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                return View(ex);
            }
            //possibly write an if statement if they are not logged in make them login 
            //else go to the dashboard
            return View();
        }
    }
}
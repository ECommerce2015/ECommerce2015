using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
            return View();
        }

        StateEntities sEntity = new StateEntities();
        public ActionResult Checkout()
        {
            if (Session["customerID"] == null)
            {
                return RedirectToAction("Index", "Registration");
            }
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
        public ActionResult ProcessCheckout(ShippingAddress shippingaddress,ShippingMethod shippingMethod,CustomerBilling customerBilling, Order order, OrderDetail orderDetail, OrderStatu orderstatus) 
        {
            int customerID = Convert.ToInt32(Session["customerID"]);
            var customerEmail = Session["customerEmail"].ToString();
            try
            {
                using (ShippingAddressEntities shippingEntities = new ShippingAddressEntities()) 
                {
                    CustomerAddressEntities cAddentity = new CustomerAddressEntities();
                    
                    List<CustomerAddress> customeraddress = cAddentity.CustomerAddresses.Where(x => x.customerAddress_ID == customerID).ToList();
                    shippingaddress.customer_ID = customerID;
                    shippingaddress.CustomerAddress_ID = customeraddress[0].customerAddress_ID;
                    shippingEntities.ShippingAddresses.Add(shippingaddress);
                    shippingEntities.SaveChanges();
                }
                using(CustomerBillingEntities customerBillingentity = new CustomerBillingEntities())
                {
                    customerBilling.customer_ID = customerID;
                    customerBillingentity.CustomerBillings.Add(customerBilling);
                    customerBillingentity.SaveChanges();
                }
                //loop through products in the cart session 
                //the information is used to populate database
                foreach (Item item in (List<Item>)Session["cart"])
                {
                    using (OrderDetailsEntities orderDetailsEntities = new OrderDetailsEntities())
                    {
                        orderDetail.product_ID = item.Pr.product_ID;
                        orderDetail.quantity = item.Pr.quantity;
                        orderDetail.total = item.Pr.quantity * item.Pr.price;
                        orderDetailsEntities.OrderDetails.Add(orderDetail);
                        orderDetailsEntities.SaveChanges();
                    }
                    using (OrdersEntities ordersEntity = new OrdersEntities())
                    {
                        decimal total = item.Pr.quantity * item.Pr.price;
                        order.orderDetails_ID = orderDetail.orderDetails_ID;
                        order.customer_ID = customerID;
                        order.orderStatus_ID = 1; //pending order look at table OrderStatus
                        order.customerBilling_ID = customerBilling.customerBilling_ID;
                        order.shippingAddress_ID = shippingaddress.shippingAddress_ID;
                        order.shippingMethod_ID = shippingMethod.shippingMethod_ID;
                        order.customerBilling_ID = customerBilling.customerBilling_ID;
                        order.orderDate = DateTime.Now;
                        order.tax = total  * Convert.ToDecimal(.07);
                        order.grandTotal = order.tax + total;
                        ordersEntity.Orders.Add(order);
                        ordersEntity.SaveChanges();
                    }
                }
                return RedirectToAction("Sent");
            }
            catch(SmtpException ex)
            {
                return View("Checkout");
            }
            catch (Exception ex)
            {
                return View("Checkout");
            }
            //possibly write an if statement if they are not logged in make them login 
            //else go to the dashboard
            return RedirectToAction("Index","Home");
        }
        public ActionResult Sent()
        {
            return View();
        }
    }
}
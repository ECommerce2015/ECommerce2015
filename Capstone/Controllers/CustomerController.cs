using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Models;
using System.Data;

namespace Capstone.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/
        
        CustomerBilling cbEntities = new CustomerBilling();
        OrdersEntities oEntities = new OrdersEntities();
        OrderDeatilsEntities odEntities = new OrderDeatilsEntities();
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Account(int userID)
        {
            if (ModelState.IsValid)
            {
                using (CustomerEntities cEntities = new CustomerEntities())
                {
                    ViewBag.customerInfo = cEntities.Customers.Where(x => x.customer_ID == userID).ToList();
                }
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Account([Bind(Include = "customer_ID,firstName,lastName,email,phone")] Customer customer)
        {
            if (ModelState.IsValid)
            {
                using (CustomerEntities cEntities = new CustomerEntities())
                {
                    cEntities.Entry(customer).State = EntityState.Modified;
                    cEntities.SaveChanges();
                    return RedirectToAction("Account");
                }
            }
            return View();            
        }
        [HttpGet]
        public ActionResult Address(int custaddID) 
        {
            if (ModelState.IsValid) 
            {
                using(CustomerAddressEntities caEntities = new CustomerAddressEntities())
                {
                    ViewBag.customerInfo = caEntities.CustomerAddresses.Where(x => x.customerAddress_ID == custaddID).ToList();
                }
            }
            return View();
        }
        [HttpPost]
        public ActionResult Address([Bind(Include = "customerAddress_ID,address1,address2,city,state,zip")] CustomerAddress
            customerAddress)
        {
            if (ModelState.IsValid)
            {
                using (CustomerAddressEntities caEntities = new CustomerAddressEntities())
                {
                    ViewBag.customerInfo = caEntities.CustomerAddresses.Where(x => x.customerAddress_ID == customerAddress.customerAddress_ID).ToList();
                }
            }
            return View();
        }
        public ActionResult Billing()
        {
            return View();
        }
        public ActionResult Orders() 
        {
            return View();
        }
    }
}

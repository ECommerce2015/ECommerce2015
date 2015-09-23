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
        OrderDetailsEntities odEntities = new OrderDetailsEntities();
        public ActionResult Index()
        {
            if (Session["customerID"] == null) 
            {
                return  RedirectToAction("Index","Registration");
            }
            if (Session["customerID"] != null)
            {
                using (CustomerEntities cEntites = new CustomerEntities())
                {
                    int customerID = Convert.ToInt32(Session["customerID"]);
                    List<Customer> customerList = cEntites.Customers.Where(x => x.customer_ID == customerID).ToList();
                    ViewBag.customerName = customerList[0].firstName + " " + customerList[0].lastName;
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult Account()
        {
            if (ModelState.IsValid)
            {
                using (CustomerEntities cEntities = new CustomerEntities())
                {
                    int customerID = Convert.ToInt32(Session["customerID"]);
                    ViewBag.customerInfo = cEntities.Customers.Where(x => x.customer_ID == customerID).ToList();
                }
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Account(Customer customer)
        {
            if (ModelState.IsValid)
            {
                using (CustomerEntities cEntities = new CustomerEntities())
                {
                    customer.customer_ID = Convert.ToInt32(Session["customerID"]);
                    cEntities.Entry(customer).State = EntityState.Modified;
                    cEntities.SaveChanges();
                    return RedirectToAction("Account");
                }
            }
            return View();            
        }
        [HttpGet]
        public ActionResult Address() 
        {
            if (ModelState.IsValid) 
            {
                using(CustomerAddressEntities caEntities = new CustomerAddressEntities())
                {
                    int customerID = Convert.ToInt32(Session["customerID"]);
                    ViewBag.customerAdddressinfo = caEntities.CustomerAddresses.Where(x => x.customer_ID == customerID).ToList();
                }
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Address(CustomerAddress customerAddress)
        {
            if (ModelState.IsValid)
            {
                using (CustomerAddressEntities caEntities = new CustomerAddressEntities())
                {
                    caEntities.Entry(customerAddress).State = EntityState.Modified;
                    caEntities.SaveChanges();
                    return RedirectToAction("Address");
                }
            }
            return View();
        }
        [HttpGet]
        public ActionResult Billing()
        {
            if (ModelState.IsValid)
            {
                int customerID = Convert.ToInt32(Session["customerID"]);
                using(CustomerBillingEntities cbentities = new CustomerBillingEntities())
                {
                    ViewBag.customerBillinginfo = cbentities.CustomerBillings.Where(x => x.customer_ID == customerID).ToList().FirstOrDefault();
                }
            }
            return View();
        }
        public ActionResult Signout()
        {
            return RedirectToAction("Index", "Signout");
        }
    }
}

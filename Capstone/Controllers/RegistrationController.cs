using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Models;

namespace Capstone.Controllers
{
    public class RegistrationController : Controller
    {
        //Entity state object
        StateEntities sEntity = new StateEntities();
        //
        // GET: /Registration/
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.StatesList = sEntity.States.ToList();
            return View("LoginRegister");
        }

        public JsonResult CheckEmail(Customer customer) 
        {
            bool answer;
            using (CustomerEntities cEntity = new CustomerEntities())
            {
                var email = cEntity.Customers.Where(x=>x.email == customer.email).FirstOrDefault();
                answer = (email != null) ? false : true;
            }
            return Json(answer, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult Register(Customer customer, CustomerAddress customerAddress, CustomerLogin customerLogin) 
        {
            string viewChange = "";
            try
            {
                if (ModelState.IsValid)
                {
                    //encrypt the password
                    customerLogin.password = HashKey.GetHashKey(customerLogin.password);
                    //inserting into customers table
                    using (CustomerEntities cEntityy = new CustomerEntities())
                    { 
                        cEntityy.Customers.Add(customer);
                        cEntityy.SaveChanges();
                    }
                    using (CustomerAddressEntities caEntity = new CustomerAddressEntities())
                    {
                        //inserting into customer address table
                        caEntity.CustomerAddresses.Add(customerAddress);
                        caEntity.SaveChanges();
                    }
                    using (CustomerLoginEntities clEntity = new CustomerLoginEntities())
                    {
                        customerLogin.customer_ID = customer.customer_ID;
                        customerLogin.email = customer.email;
                        customerLogin.dateCreated = DateTime.Now;
                        //inserting into customer login table
                        clEntity.CustomerLogins.Add(customerLogin);
                        clEntity.SaveChanges();
                        return RedirectToAction("Index", "Customer", new { customer_ID = customerLogin.customer_ID });
                    }
                }
                else 
                {
                    viewChange = "LoginRegister";
                }
            }
            catch(EntryPointNotFoundException ex){}
            catch (Exception ex) { viewChange = "LoginRegister"; }
            return View(viewChange);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login() 
        {
            return View();
        }
    }
}

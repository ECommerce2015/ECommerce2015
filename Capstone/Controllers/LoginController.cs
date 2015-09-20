using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Models;
using System.Web.Security;
using System.Security.Policy;
using System.Data;

namespace Capstone.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return RedirectToAction("Index", "Registration");
        }
        [HttpPost]
        public ActionResult Login(CustomerLogin customerLogin) 
        {        
            using(CustomerLoginEntities clEntity = new CustomerLoginEntities())
            {
                //hashing user entry password
                customerLogin.password = HashKey.GetHashKey(customerLogin.password);
                //checking database if user is valid
                bool userIsValid = clEntity.CustomerLogins.Any(loginTable=>loginTable.email == customerLogin.email && loginTable.password == customerLogin.password);
                //checking if user is valid
                if (userIsValid)
                {
                    CustomerLogin customer = clEntity.CustomerLogins.Where(loginTable => loginTable.email == customerLogin.email && loginTable.password == customerLogin.password).FirstOrDefault<CustomerLogin>();
                    customer.dateCreated = DateTime.Now;
                    customer.password = customerLogin.password;
                    clEntity.Entry(customer).State = EntityState.Modified;
                    clEntity.SaveChanges();
                    Session["customerID"] = customer.customer_ID;
                    Session["customerEmail"] = customer.email;
                    return RedirectToAction("Index", "Home", new{customer_ID = customer.customer_ID}); 
                }
                else
                { ModelState.AddModelError("", "Email or Password provided is incorrect!"); }                                    
            }
            return RedirectToAction("Index", "Registration");
        }
    }
}

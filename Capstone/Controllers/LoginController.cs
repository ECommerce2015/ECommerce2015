using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Models;
using System.Web.Security;
using System.Security.Policy;

namespace Capstone.Controllers
{
    public class LoginController : Controller
    {
        //
        // GET: /Login/

        public ActionResult Index()
        {
            return View("LoginRegister");
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
                    customerLogin.dateCreated = DateTime.Now;
                    clEntity.CustomerLogins.Add(customerLogin);
                    return RedirectToAction("Index", "Customer"); 
                }
                else
                { ModelState.AddModelError("", "Email or Password provided is incorrect!"); }                                    
            }
            return View(customerLogin);
        }
    }
}

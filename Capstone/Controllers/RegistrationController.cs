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
        //Entity objects
        StateEntities sEntity = new StateEntities();
        CustomerEntities cEntityy = new CustomerEntities(); 
        CustomerAddressEntities caEntity = new CustomerAddressEntities();
        CustomerLoginEntities clEntity = new CustomerLoginEntities();
        //
        // GET: /Registration/
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.StatesList = sEntity.States.ToList();
            return View("LoginRegister");
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
                    cEntityy.Customers.Add(customer);
                    cEntityy.SaveChanges();
                    //inserting into customer address table
                    caEntity.CustomerAddresses.Add(customerAddress);
                    caEntity.SaveChanges();


                    //inserting into customer login table
                    clEntity.CustomerLogins.Add(customerLogin);
                    clEntity.SaveChanges();
                    viewChange = "HomeDashBoard";
                }
                else 
                {
                    viewChange = "LoginRegister";
                }
            }
            catch(EntryPointNotFoundException ex){}
            catch(Exception ex){}
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

using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.Controllers
{
    public class RegisterController : Controller
    {
        //
        // GET: /Register/
        [HttpGet]
        public ActionResult LoginRegister()
        {
            //instance of Address model
            Address address = new Address();
            ViewBag.States = address.GetStates();
            return View();
        }
        [HttpPost]
        public ActionResult Register() 
        {
            return View();
        }
    }
}

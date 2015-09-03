using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.Controllers
{
    public class CustomerController : Controller
    {
        //
        // GET: /Customer/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Account()
        {
            return View();
        }
        public ActionResult Address() 
        {
            return View();
        }
        public ActionResult Orders() 
        {
            return View();
        }
    }
}

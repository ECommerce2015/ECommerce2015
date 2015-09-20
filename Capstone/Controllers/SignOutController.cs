using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Capstone.Controllers
{
    public class SignOutController : Controller
    {
        //
        // GET: /SignOut/

        public ActionResult Index()
        {
            Session.Clear();
            return RedirectToAction("Index","Home");
        }

    }
}

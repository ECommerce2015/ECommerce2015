using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Models;

namespace Capstone.Controllers
{
    public class HomeController : Controller
    {

        private CategoryEntities category = new CategoryEntities(); 
        [HttpGet]

        public ActionResult Index()
        {
            ViewBag.listCategories = category.Categories.ToList();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        public ActionResult Delivery()
        {
            ViewBag.Message = "";
            return View(); 
        }

        public ActionResult News() 
        {
            ViewBag.Message = "";
            return View();
        }

        public ActionResult Preview()
        {
            ViewBag.Message = "";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
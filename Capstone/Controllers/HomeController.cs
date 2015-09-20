using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Capstone.Models;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

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
        public ActionResult Products(int category_ID)
        {
            //this will redirect to the Product controller Products method
            //simply allows you to jump to another controller
            return RedirectToAction("Products", "Product", new { category_ID = category_ID });
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SendContact(ContactEmail contactEmail) 
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                    MailMessage message = new MailMessage();
                    message.To.Add(new MailAddress("tnunez@email.neit.edu"));  // replace with valid value 
                    message.Subject = "Customer Contact";
                    message.Body = string.Format(body, contactEmail.FromName, contactEmail.FromEmail, contactEmail.Message);
                    message.IsBodyHtml = true;

                    using (SmtpClient smtp = new SmtpClient())
                    {
                        smtp.Send(message);
                        return RedirectToAction("Sent");
                    }
                }
            }catch(SmtpException ex)
            {
                RedirectToAction("Contact","Home");
            }
            catch(Exception ex)
            {
                RedirectToAction("Contact","Home");
            }
            return RedirectToAction("Contact");
        }
        public ActionResult Sent()
        {
            return View();
        }
    }
}
//403 project 1; Mission Site; Lauren Faber, Cody Hyer, Katy Vance, Stephen Godderidge
//10/31/16
//Website to let future missionaries learn about 3 specific missions and ask questions.
// includes a home page, an about page, and a mission page.  From the mission page, you can
// select to view information about 3 missions.  


using MVCEmail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MissionSite.Controllers
{
    public class HomeController : Controller
    {
        //Controller for the home page
        public ActionResult Index()
        {
            return View();
        }
        //controller for the about page
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //controller for the contact page
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        //cody

        //controller for the email
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress("codygarbage14@gmail.com"));   
                message.From = new MailAddress("sender@outlook.com");  
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;
                using (var smtp = new SmtpClient())
                {
                    var credential = new NetworkCredential
                    {
                        UserName = "codygarbage14@gmail.com",
                        Password = "yellowfever"
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }

        public ActionResult Sent()
        {
            return View();
        }
    }

}
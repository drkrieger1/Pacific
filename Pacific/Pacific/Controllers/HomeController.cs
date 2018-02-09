using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Pacific.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Pacific.Controllers
{
    public class HomeController : Controller 
    {
        private IConfiguration _Configuration { get; set; } 

        public HomeController(IConfiguration config)
        {
            _Configuration = config;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Connect([Bind("Name,Phone,Email,Comment")]QuickEmail lead)
        {
            if (ModelState.IsValid)
            {
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Client Lead", "webServices@pqconstruction.us"));
                message.To.Add(new MailboxAddress($"{lead.Name} ", "eplyushko@gmail.com"));
                message.Subject = "Connection Lead";
                message.Body = new TextPart("plain")
                {
                    Text = $"Name:{lead.Name} | Phone:{lead.Phone} | Email:{lead.Email} \n Message: {lead.Comment}"
                };
                
                //gathering login info
                var user = _Configuration.GetConnectionString("User_Name");
                var password = _Configuration.GetConnectionString("Email_Password");
                using (var client = new SmtpClient())
                {
                    client.Connect("smtp.zoho.com", 587, false);
                    client.Authenticate(user, password);
                    client.Send(message);
                    client.Disconnect(true);
                }
                return Redirect("/Home/Index");
            }
            

            return Redirect("/Home/Index");
        }

    }
}

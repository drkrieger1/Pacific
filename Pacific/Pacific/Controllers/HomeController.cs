using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacific.Controllers
{
    public class HomeController : Controller 
    {
        //IActionResult Index()
        //{
        //    return View();
        //}

        //public string Index()
        //{
        //    return "WtF?";
        //}

        public IActionResult Index()
        {
            return View();
        }
    }
}

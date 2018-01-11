using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacific.Controllers
{
    public class HomeController : Controller 
    {   
        //WHY YOU DO DIS? 
        //IActionResult Index()
        //{
        //    return View();
        //}

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
    }
}

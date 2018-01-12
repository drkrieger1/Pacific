using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pacific.Data;
using Pacific.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacific.Controllers
{
    public class LeadController : Controller 
    {   
        //Lead Db context dependency injection
        private readonly LeadDbContext _Context; 
        
        //Cunstructor to requier a Db Context 
        public LeadController(LeadDbContext context)
        {
            _Context = context;
        }

        //Index gathering All Leads from Db Context 
        public async Task<IActionResult> Index(string searchString)
        {
            if (!String.IsNullOrEmpty(searchString))
            {
                return View(await _Context.Lead.Where(c => c.Name.Contains(searchString)).ToListAsync());
            }

            return View(await _Context.Lead.ToListAsync());
        }

        //Get: Create
        public IActionResult Create()
        {
            return View();
        }

        //Post: Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID, Name, Phone, Email, Comment, Date")] Lead lead)
        {   
            if (ModelState.IsValid)
            {
                lead.Date = DateTime.UtcNow;
                
                _Context.Add(lead);
                await _Context.SaveChangesAsync();
                return RedirectToAction(("/Home/Index"));
            }
            return View();
        }

        //edit 

        //Delete 
    }
}

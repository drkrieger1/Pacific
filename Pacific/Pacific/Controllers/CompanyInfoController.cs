using Microsoft.AspNetCore.Mvc;
using Pacific.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacific.Controllers
{
    public class CompanyInfoController : Controller 
    {
        ////Lead Db context dependency injection
        //private readonly CompanyInfoDbContext _Context;

        ////Cunstructor to requier a Db Context 
        //public CompanyInfoController(CompanyInfoDbContext context)
        //{
        //    _Context = context;
        //}

        ////Index gathering All Leads from Db Context 
        //public async Task<IActionResult> Index(string searchString)
        //{
        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        return View(await _Context.CompanyInfo.Where(c => c.Name.Contains(searchString)).ToListAsync());
        //    }

        //    return View(await _Context.Lead.ToListAsync());
        //}

        ////Get: Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        ////Post: Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("ID, Name, Phone, Email, Comment, Date")] Lead lead)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        lead.Date = DateTime.UtcNow;

        //        _Context.Add(lead);
        //        await _Context.SaveChangesAsync();
        //        return Redirect("/Home/Index");
        //    }
        //    return View();
        //}

        ////Get: edit action
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    //check if lead exists
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    //Get selected Lead

        //    var lead = await _Context.Lead
        //        .SingleOrDefaultAsync(l => l.ID == id);

        //    if (lead == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(lead);
        //}

        ////Post: for Edit method
        //public async Task<IActionResult> Edit(int id, [Bind("ID, Name, Phone, Email, Comment, Date")] Lead lead)
        //{
        //    //Check for leads existance
        //    if (id != lead.ID)
        //    {
        //        return NotFound();
        //    }

        //    //Apply and save Edits
        //    if (ModelState.IsValid)
        //    {
        //        _Context.Update(lead);
        //        await _Context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(lead);
        //}

        ////Get: Delete method that will select a lead to delete
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    //Check for leads existance
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    //Retreving the selected lead for deletion
        //    var lead = await _Context.Lead
        //        .SingleOrDefaultAsync(l => l.ID == id);
        //    if (lead == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(lead);
        //}

        ////Post: delete confermation
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    //selected lead for deletion
        //    var lead = await _Context.Lead
        //        .SingleOrDefaultAsync(l => l.ID == id);

        //    //Lead deletion
        //    _Context.Lead.Remove(lead);
        //    await _Context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}
    }
}

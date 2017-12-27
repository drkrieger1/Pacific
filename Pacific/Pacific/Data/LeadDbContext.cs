using Microsoft.EntityFrameworkCore;
using Pacific.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacific.Data
{   
    //DbContext for Leads(contacts)
    public class LeadDbContext : DbContext
    {
        public LeadDbContext(DbContextOptions<LeadDbContext>Options): base(Options)
        {

        }

        public DbSet<Lead>Lead { get; set; }
    }
}

﻿using Microsoft.EntityFrameworkCore;
using Pacific.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pacific.Data
{   
    //Db Context for company information
    public class CompanyInfoDbContext : DbContext 
    {
        public CompanyInfoDbContext(DbContextOptions<CompanyInfoDbContext>Options): base(Options)
        {

        }

        public DbSet<CompanyInfo> CompanyInfo { get; set; }
    }
}

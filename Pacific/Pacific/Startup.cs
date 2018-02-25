using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Pacific.Data;
using Microsoft.EntityFrameworkCore;
using Pacific.Models;
using Microsoft.AspNetCore.Identity;

namespace Pacific
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            //This is the Context for company info and leads database models
            //services.AddDbContext<CompanyInfoDbContext>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("PacificContext")));
            //services.AddDbContext<LeadDbContext>(options =>
            //        options.UseSqlServer(Configuration.GetConnectionString("PacificContext")));

            //This context is derived from IdentityDbContext
            //services.AddDbContext<ApplicationDbContext>(options => 
            //options.UseSqlServer(Configuration.GetConnectionString("PacificContext")));
           
            //Enable Identity Functionality using ApplicationUser model
            //services.AddIdentity<ApplicationUser, IdentityRole>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>()
            //    .AddDefaultTokenProviders();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                context.Response.Redirect("/Home/Index", false);
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
}

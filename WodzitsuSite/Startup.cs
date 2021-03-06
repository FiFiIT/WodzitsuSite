﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using WodzitsuSite.Data;
using Microsoft.EntityFrameworkCore;
using WodzitsuSite.Data.Repositories;

namespace WodzitsuSite
{
    public class Startup
    {
        private IConfiguration Configuration;
        public Startup(IConfiguration Configuration)
        {
            this.Configuration = Configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<TourContext>(cfg => cfg.UseSqlServer(Configuration.GetConnectionString("Wodzitsu")));
            services.AddScoped<ITourRepository, TourRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();
            app.UseNodeModules(env);

            app.UseMvc(cfg =>
            {
                cfg.MapRoute("Default", "/{controller}/{action}/{id?}", new { controller = "App", action = "Index" });
            });
        }
    }
}

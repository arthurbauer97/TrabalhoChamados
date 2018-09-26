using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TrabalhoChamados.Models;

namespace TrabalhoChamados
{
    public class Startup
    {
        public Startup(IConfiguration configuration) 
        {
            this.Configuration = configuration;
               
        }
                public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
      
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<DataContext>(x=>
                x.UseMySql(Configuration.GetConnectionString("DefaultConnection")));
            
            services.AddScoped<IChamadoRepository,ChamadoRepository>();
            services.AddScoped<IClienteRepository,ClienteRepository>();
            services.AddScoped<ISituacaoRepository,SituacaoRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

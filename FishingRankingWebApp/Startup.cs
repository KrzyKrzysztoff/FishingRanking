using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FishingRankingWebApp.Abstractions;
using FishingRankingWebApp.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace FishingRankingWebApp
{
    public class Startup
    {
        private readonly IConfiguration configuration;
    

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;

        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IHomeRepository, HomeRepository>();
            services.AddTransient<IUserRepository, UserRepository>();
            services.AddTransient<IAdminRepository, AdminRepository>();

            services.AddIdentity<IdentityUser, IdentityRole>()
                .AddEntityFrameworkStores<AppDbContext>();
            services.AddTransient<AppDbContextSeedData>();
            services.AddDbContextPool<AppDbContext>(s => s.UseSqlServer(configuration.GetConnectionString("FishingRankingCS")));
            services.AddMvc();
            services.AddRazorPages().AddRazorRuntimeCompilation();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, AppDbContextSeedData seeder)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

            }
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
               
                endpoints.MapControllerRoute(
                   
                    name: "defualt",
                    pattern: "{Controller=Account}/{Action=Login}/{Id?}"
                    );
            });
        
        }
    }
}

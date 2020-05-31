using Estimator.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.DataProtection;
using System.IO;

using System;
namespace Estimator
{
    public class Startup
    {
        IWebHostEnvironment _env;
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            _env = env;

        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           
            services.AddRazorPages()
               .AddRazorPagesOptions(options =>
                {
                    options.Conventions.AuthorizeFolder("/Customer");
                    options.Conventions.AuthorizeFolder("/CustomerRequests");
                    options.Conventions.AuthorizeFolder("/Program");
                    options.Conventions.AuthorizeFolder("/ElementKey");

                });
           

            // установка конфигурации подключения к базе данных калькулятора
            services.AddDbContext<EstimatorContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("EstimatorContext")));
            // это чтобы ыорма импорта не отваливалать. Слишком много данных в форме.
            services.Configure<FormOptions>(x => x.ValueCountLimit = int.MaxValue‬);
            services.AddDataProtection()
                .SetApplicationName ("Estimator")
                .PersistKeysToFileSystem(new DirectoryInfo(_env.WebRootPath + "/Files/")); ;

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options => //CookieAuthenticationOptions
                {
                    options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Login");
                    options.ExpireTimeSpan =System.TimeSpan.FromMinutes(1440);
                
                });


        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

         //  env.
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthentication();    // аутентификация
            app.UseAuthorization();     // авторизация


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}

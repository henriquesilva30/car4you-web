using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using car4you.Model;
using car4you.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace car4you
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

           // services.AddRazorPages();
            //services.AddMvc();
           
         //   services.AddTransient<User>();
            services.AddDbContext<storeContext>(options =>
            {
                options.UseOracle(@"User Id=car4you;Password=qwerty2000;Data Source=localhost;");
                
                
            });
            services
                .AddControllersWithViews()
                .AddJsonOptions(options =>
                {
                    options.JsonSerializerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
                });
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
            {
                options.LoginPath = "/login";
                options.AccessDeniedPath = "/denied";
                options.Events = new CookieAuthenticationEvents()
                {
                    OnSigningIn  = async context =>
                    {
                       /* var principal = context.Principal;
                        if(principal.HasClaim(c=>c.Type == ClaimTypes.NameIdentifier)) {
                            if (principal.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier).Value ==
                                "bob")
                            {
                                var claimsIdentity = principal.Identity as ClaimsIdentity;
                                claimsIdentity.AddClaim(new Claim(ClaimTypes.Role,"0"));

                            }
                        }*/
                        await Task.CompletedTask;
                    },
                    OnSignedIn = async context =>
                    {
                        await Task.CompletedTask;
                    },
                    OnValidatePrincipal = async context =>
                    {
                        await Task.CompletedTask;
                    }
                };
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
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            //  endpoints.MapRazorPages();
            });
        }
    }
}
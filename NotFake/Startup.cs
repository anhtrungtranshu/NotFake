using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using Service;
using DAO;
using Microsoft.AspNetCore.Authentication.Cookies;
using NotFake.Hubs;
using NotFake.ChatService;
using DAO.Models;
using System.Security.Claims;

namespace NotFake
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
            AppContext.SetSwitch("Switch.Microsoft.AspNetCore.Mvc.EnableRangeProcessing", true);
            services.AddHttpClient();
            services.AddHttpContextAccessor();
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            

            // var sqlConnectionString = Configuration.GetConnectionString("DefaultConnection");
            var sqlConnectionString = Configuration.GetConnectionString("AlternativeConnection");

            services.AddDbContext<NotFakeContext>(options =>
                options.UseSqlServer(sqlConnectionString)
            );

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(options =>
                {
                options.AccessDeniedPath ="/Home/Index";
                });

            services.AddScoped<INotFakeService, NotFakeService>();
            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddSignalR();
            services.AddSingleton<IChatRoomService, InMemoryChatRoomService>();
            services.AddAuthorization(options =>
            {
                
                options.AddPolicy("User", policy =>
                {
                    policy.RequireClaim(ClaimTypes.Role, UserRoles.User.ToString(), UserRoles.Admin.ToString());
                });
                options.AddPolicy("Admin", policy =>
                {
                    policy.RequireClaim(ClaimTypes.Role, UserRoles.Admin.ToString());
                });
                
            });
           
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
            }

            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSignalR(routes =>
            {
                routes.MapHub<ChatHub>("/chatHub");
            });
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

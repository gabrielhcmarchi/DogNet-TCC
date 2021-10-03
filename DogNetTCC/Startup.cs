using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using DogNet.Data;
using DogNet.Services;
using System.Globalization;
using DogNet.Entities;
using DogNet.Models;

namespace DogNet
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        [Obsolete]
        public void ConfigureServices(IServiceCollection services)

        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // habilita a necessidade de consentimento para uso de cookie
                options.CheckConsentNeeded = context => true;
                // adicionar using Microsoft.AspNetCore.Http;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddIdentity<AppUser, IdentityRole>(options =>
            {
                options.User.RequireUniqueEmail = true; //default = false
                options.Password.RequireNonAlphanumeric = false; //default = true
                options.Password.RequireUppercase = false; //default = true
                options.Password.RequireLowercase = false; //default = true               
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(3); //default = 3
                options.Lockout.MaxFailedAccessAttempts = 3; //default = 5
                options.SignIn.RequireConfirmedAccount = false; //default = false
                options.SignIn.RequireConfirmedEmail = true; //default = false
                options.SignIn.RequireConfirmedPhoneNumber = false; //default = false                
            }).AddEntityFrameworkStores<DogNetMvcContext>()
              .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                options.LoginPath = "/Login";
                options.AccessDeniedPath = "/Login";
                options.SlidingExpiration = true;
            });

            services.AddAuthorization(options =>
            {
                //adiciona uma política de acesso chamada isAdmin
                options.AddPolicy("isAdmin", policy =>
                    policy.RequireRole("admin"));
            });

            services.AddRazorPages(options =>
            {
                options.Conventions.AuthorizePage("/Admin/Admin", "isAdmin");
                options.Conventions.AuthorizeFolder("/Admin/ProdutoCRUD", "isAdmin");
            }).AddCookieTempDataProvider(options =>
            {
                options.Cookie.IsEssential = true;
            });

            services.AddMvc();

            string mySqlConnectionStr = Configuration.GetConnectionString("DogNetMvcContext");

          

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddDbContext<DogNetMvcContext>(options =>
                    options.UseMySql(Configuration.GetConnectionString("DogNetMvcContext"), builder =>
                        builder.MigrationsAssembly("DogNet")));



            services.Configure<EmailConfiguration>(Configuration.GetSection("EmailConfiguration"));
            //services.AddSingleton<IEmailSender, EmailSender>();
            services.AddSingleton<IEmailSender, SendGridSender>();


            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);

            
            services.AddControllers();
            services.AddMvc(options => options.EnableEndpointRouting = false);
     

           

           
           

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        [Obsolete]
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts();
            }

            //app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
            });

            var defaultCulture = new CultureInfo("pt-BR");
            var localizationOptions = new RequestLocalizationOptions
            {
                DefaultRequestCulture = new RequestCulture(defaultCulture),
                SupportedCultures = new List<CultureInfo> { defaultCulture },
                SupportedUICultures = new List<CultureInfo> { defaultCulture }
            };
            app.UseRequestLocalization(localizationOptions);

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

     
        }
    }
}

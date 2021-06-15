using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyCompany.Domain.Repositories.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using WebApplicationPFR.Domain;
using WebApplicationPFR.Domain.Repositories.Abstract;
using WebApplicationPFR.Domain.Repositories.EntityFramework;
using WebApplicationPFR.Service;

namespace WebApplicationPFR
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;
        public void ConfigureServices(IServiceCollection services)
        {
            //подключение конфигурации из appsetting.json
            Configuration.Bind("Project", new Config());

            //подлючение функционала приложения в качестве сервиса
            services.AddTransient<IEmployesRepositories, EFEmployesRepository>();
            services.AddTransient<IMonitorsRepositories, EFMonitorsRepository>();
            services.AddTransient<IPCRepositories, EFPCRepository>();
            services.AddTransient<IPrintersRepositories, EFPrintersRepository>();
            services.AddTransient<DataManager>();

            //подключение контекста бд
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

            //настройка identity системы
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //настройка authentication cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "PFRSamata";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });
            //настройка политики авторизации админа
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });



            //добавление поддержки контроллеров и представлений (Mvc)
            services.AddControllersWithViews(x =>
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin","AdminArea"));
            }).SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_3_0).AddSessionStateTempDataProvider();
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment()) app.UseDeveloperExceptionPage();

            //подключение статичных файлов в приложении 
            app.UseStaticFiles();

            //подключение системы маршрутизации
            app.UseRouting();

            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            //регистрация маршрутов 
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(name: "admin", pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapControllerRoute( name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}

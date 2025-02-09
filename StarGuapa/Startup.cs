using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using StarGuapa.DataAccess.Data;
using StarGuapa.DataAccess.Data.Repository;
using StarGuapa.Utilities;
using Microsoft.AspNetCore.Identity.UI.Services;
using StarGuapa.Models;
using StarGuapa.DataAccess.Data.Inicializador;
using StarGuapa.Models.Data.Repository;
using StarGuapa.Models.Data;

namespace StarGuapa
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<ApplicationUser , IdentityRole>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoleManager<RoleManager<IdentityRole>>()
                .AddEntityFrameworkStores<ApplicationDbContext>()
                .AddDefaultTokenProviders();

            services.AddSingleton<IEmailSender, EmailSender>();

            services.AddScoped<IArticuloRepository, ArticuloRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<ShoppingCart>(sc => ShoppingCart.GetCart(sc));
            services.AddScoped<IOrdenRepository, OrdenRepository>();


            services.AddScoped<IContenedorTrabajo, ContenedorTrabajo>();
            services.AddScoped<IInicializadorDB, InicializadorDB>();
            services.AddControllersWithViews().AddRazorRuntimeCompilation();
            services.AddRazorPages();

            services.AddHttpContextAccessor();
            services.AddSession();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, IInicializadorDB dbInicial)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
            dbInicial.Inicializar();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{area=Client}/{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}

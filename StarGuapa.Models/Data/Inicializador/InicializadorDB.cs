using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StarGuapa.Models;
using StarGuapa.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarGuapa.DataAccess.Data.Inicializador
{
    public class InicializadorDB : IInicializadorDB
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public InicializadorDB(ApplicationDbContext db, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public void Inicializar()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception)
            {
                throw;
            }

            if (_db.Roles.Any(ro => ro.Name == CNT.Administrador)) return;

            _roleManager.CreateAsync(new IdentityRole(CNT.Administrador)).GetAwaiter().GetResult();
            _roleManager.CreateAsync(new IdentityRole(CNT.Usuario)).GetAwaiter().GetResult();

            _userManager.CreateAsync(new ApplicationUser
            {
                UserName = "grace@starguapa.com",
                Email = "grace@starguapa.com",
                EmailConfirmed = true,
                Nombre = "Grace Mariaca"
            }, "Grac31266*").GetAwaiter().GetResult();

            ApplicationUser usuario = _db.ApplicationUser
                .Where(us => us.Email == "grace@starguapa.com")
                .FirstOrDefault();
            _userManager.AddToRoleAsync(usuario, CNT.Administrador).GetAwaiter().GetResult();
        }
    }
}

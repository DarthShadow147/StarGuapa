using Microsoft.AspNetCore.Mvc.Rendering;
using StarGuapa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarGuapa.DataAccess.Data.Repository
{
    public interface IUsuarioRepository : IRepository<ApplicationUser>
    {
        void BloquearUsuario(string IdUsuario);
        void DesbloquearUsuario(string IdUsuario);
    }
}

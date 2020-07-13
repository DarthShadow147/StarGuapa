using Microsoft.AspNetCore.Mvc.Rendering;
using StarGuapa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarGuapa.DataAccess.Data.Repository
{
    public interface IArticuloRepository : IRepository<Articulo>
    {
        void Update(Articulo articulo);
    }
}

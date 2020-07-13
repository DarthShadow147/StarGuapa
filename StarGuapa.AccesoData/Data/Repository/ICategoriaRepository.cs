using Microsoft.AspNetCore.Mvc.Rendering;
using StarGuapa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarGuapa.DataAccess.Data.Repository
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        IEnumerable<SelectListItem> GetListaCategorias();
        void Update(Categoria categoria);

    }
}

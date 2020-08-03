using Microsoft.AspNetCore.Mvc.Rendering;
using StarGuapa.DataAccess.Data.Repository;
using StarGuapa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarGuapa.DataAccess.Data
{
    public class CategoriaRepository : Repository<Categoria>, ICategoriaRepository
    {
        private readonly ApplicationDbContext _db;

        public CategoriaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<Categoria> GetAllCategories => _db.Categoria;

        public IEnumerable<SelectListItem> GetListaCategorias()
        {
            return _db.Categoria.Select(i => new SelectListItem()
            {
                Text = i.Nombre,
                Value = i.Id.ToString()
            });
        }

        public void Update(Categoria categoria)
        {
            var objDesdeDb = _db.Categoria.FirstOrDefault(s => s.Id == categoria.Id);
            objDesdeDb.Nombre = categoria.Nombre;
            objDesdeDb.Descripcion = categoria.Descripcion;

            _db.SaveChanges();
        }
    }
}

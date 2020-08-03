using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StarGuapa.DataAccess.Data.Repository;
using StarGuapa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StarGuapa.DataAccess.Data
{
    public class ArticuloRepository : Repository<Articulo>, IArticuloRepository
    {
        private readonly ApplicationDbContext _db;

        public ArticuloRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<Articulo> GetAllArticulos
        {
            get
            {
                return _db.Articulo.Include(c => c.Categoria);
            }
        }

        public Articulo GetArticuloById(int Id)
        {
            return _db.Articulo.FirstOrDefault(c => c.Id == Id);
        }

        public void Update(Articulo articulo)
        {
            var objDesdeDb = _db.Articulo.FirstOrDefault(s => s.Id == articulo.Id);
            objDesdeDb.Nombre = articulo.Nombre;
            objDesdeDb.Descripcion = articulo.Descripcion;
            objDesdeDb.UrlImagen = articulo.UrlImagen;
            objDesdeDb.Precio = articulo.Precio;
            objDesdeDb.CategoriaId = articulo.CategoriaId;

            //_db.SaveChanges();
        }
    }
}

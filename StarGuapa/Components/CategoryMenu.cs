using Microsoft.AspNetCore.Mvc;
using StarGuapa.DataAccess.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarGuapa.Components
{
    public class CategoryMenu : ViewComponent
    {
        private readonly ICategoriaRepository _categoriaRepository;
        public CategoryMenu(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categorias = _categoriaRepository.GetAllCategories.OrderBy(c => c.Nombre);
            return View(categorias);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StarGuapa.DataAccess.Data.Repository;
using StarGuapa.Models;
using StarGuapa.Models.ViewModels;

namespace StarGuapa.Controllers
{
    [Area("Client")]
    public class HomeController : Controller
    {
        private readonly IContenedorTrabajo _contenedorTrabajo;
        private readonly IArticuloRepository _articuloRepository;
        private readonly ICategoriaRepository _categoriaRepository;

        public HomeController(IContenedorTrabajo contenedorTrabajo, IArticuloRepository articuloRepository, ICategoriaRepository categoriaRepository)
        {
            _contenedorTrabajo = contenedorTrabajo;
            _articuloRepository = articuloRepository;
            _categoriaRepository = categoriaRepository;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Slider = _contenedorTrabajo.Slider.GetAll(),
                ListaArticulos = _contenedorTrabajo.Articulo.GetAll()
            };
            return View(homeVM);
        }

        public ViewResult Lista(string categoria)
        {
            IEnumerable<Articulo> articulos;
            string categoriaActual;

            if (string.IsNullOrEmpty(categoria))
            {
                articulos = _articuloRepository.GetAllArticulos.OrderBy(c => c.Id);
                categoriaActual = "Todos los articulos";
            }
            else
            {
                articulos = _articuloRepository.GetAllArticulos.Where(c => c.Categoria.Nombre == categoria);
                categoriaActual = _categoriaRepository.GetAllCategories.FirstOrDefault(c => c.Nombre == categoria)?.Nombre;
            }

            return View(new ArticuloCategoriaVM
            {
                Articulos = articulos,
                CategoriaActual = categoriaActual
            });
        }

        public IActionResult Details(int id)
        {
            var articulo = _articuloRepository.GetArticuloById(id);
            if (articulo == null)
                return NotFound();

            return View(articulo);
        }
    }
}

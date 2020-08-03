using System;
using System.Collections.Generic;
using System.Text;

namespace StarGuapa.Models.ViewModels
{
    public class ArticuloCategoriaVM
    {
        public IEnumerable<Articulo> Articulos { get; set; }
        public string CategoriaActual { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StarGuapa.Models
{
    public class OrdenDetalle
    {
        [Key]
        public int Id { get; set; }
        public int OrdenId { get; set; }
        public int articuloId { get; set; }
        public Articulo Articulo { get; set; }
        public int Cantidad { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Precio { get; set; }
    }
}

using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StarGuapa.Models
{
    public class Orden
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Ingrese su nombre")]
        [Display(Name = "Nombres")]
        [StringLength(30)]
        public string Nombres { get; set; }


        [Required(ErrorMessage = "Ingrese su apellido")]
        [Display(Name = "Apellidos")]
        [StringLength(50)]
        public string Apellidos { get; set; }


        [Required(ErrorMessage = "Ingrese el tipo de direccion")]
        [Display(Name = "Dirección")]
        public string Direccion { get; set; }


        [Required(ErrorMessage = "Ingrese la direccion completa")]
        public string CalleCampo1 { get; set; }


        [Required(ErrorMessage = "Ingrese la direccion completa")]
        public string CalleCampo2 { get; set; }


        [Required(ErrorMessage = "Ingrese la direccion completa")]
        public string CalleCampo3 { get; set; }


        [Display(Name = "Tipo de Inmueble")]
        public string TipoInmueble { get; set; }


        public string TipoInmuebleDesc { get; set; }


        [Display(Name = "Bloque o Interior")]
        public string BloqueInterior { get; set; }


        public string BloqueOInteriorDesc { get; set; }


        [Required(ErrorMessage = "Ingrese el departamento")]
        [Display(Name = "Departamento")]
        public string Departamento { get; set; }


        [Required(ErrorMessage = "Ingrese la cuidad")]
        [Display(Name = "Cuidad")]
        public string Ciudad { get; set; }


        [Required(ErrorMessage = "Ingrese el barrio")]
        [Display(Name = "Barrio")]
        [StringLength(80)]
        public string Barrio { get; set; }


        [Required(ErrorMessage = "Ingreso el telefono")]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefono")]
        public string Telefono { get; set; }


        public string Observaciones { get; set; }


        public List<OrdenDetalle> OrdenDetalle { get; set; }


        [Column(TypeName = "decimal(18,2)")]
        public decimal OrdenTotal { get; set; }


        [BindNever]
        public DateTime OrdenFecha { get; set; }


        [BindNever]
        public int Estado { get; set; }
    }
}

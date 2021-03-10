using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Sistema.Entidades.Almacen
{
    public class DetalleIngreso
    {
        public int iddetalle_ingreso { get; set; }
        [Required]
        public int idingreso { get; set; }
        [Required]
        public int idarticulo { get; set; }
        [Required]
        public int cantidad { get; set; }
        [Required]
        public decimal precio { get; set; }
        public Ingreso ingreso { get; set; }
        public Articulo articulo { get; set; }
    }
}

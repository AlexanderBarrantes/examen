using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiExamenFinal.Models
{
    public class Inventario
    {
        [Key]
        public int Identificador { get; set; }
        public string Producto { get; set; }
        public string Cantidad { get; set; }
        public int CantidadMinima { get; set; }
        public int CantidadMaxima { get; set; }
        public bool GravadoExento { get; set; } 
    }
}
using System;
using System.ComponentModel.DataAnnotations;

namespace ComisionesVentas.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public required int VendedorId { get; set; }  // Propiedad requerida
        public required DateTime Fecha { get; set; }  // Propiedad requerida
        public required decimal Monto { get; set; }   // Propiedad requerida
        public required int ReglaId { get; set; }     // Propiedad requerida
        public Vendedor Vendedor { get; set; }
        public Regla Regla { get; set; }
    }
}
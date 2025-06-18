using System;
using System.ComponentModel.DataAnnotations;

namespace ComisionesVentas.Models
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required int VendedorId { get; set; }
        public virtual required Vendedor Vendedor { get; set; } // Usar required para navegación
        [Required]
        public required DateTime Fecha { get; set; }
        [Required]
        public required decimal Monto { get; set; }
        [Required]
        public required int ReglaId { get; set; }
        public virtual required Regla Regla { get; set; } // Usar required para navegación
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComisionesVentas.Models
{
    public class Regla
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required decimal MontoMinimo { get; set; }
        public decimal MontoMaximo { get; set; } // Puede ser nulo o opcional
        [Required]
        public required decimal PorcentajeComision { get; set; }
        public virtual required ICollection<Venta> Ventas { get; set; } // Usar required para navegación
    }
}
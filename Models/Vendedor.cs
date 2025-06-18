using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComisionesVentas.Models
{
    public class Vendedor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Nombre { get; set; } // Usar required
        public string? Email { get; set; } // Permitir nulo con ?
        public virtual required ICollection<Venta> Ventas { get; set; } // Usar required para navegación
    }
}
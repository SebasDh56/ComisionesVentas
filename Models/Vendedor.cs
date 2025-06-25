using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComisionesVentas.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public required string Nombre { get; set; } // Propiedad requerida
        public required string Email { get; set; }  // Propiedad requerida
    }
}
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComisionesVentas.Models
{
    public class Regla
    {
        public int Id { get; set; }
        public required decimal MontoMinimo { get; set; }  // Propiedad requerida
        public required decimal MontoMaximo { get; set; }  // Propiedad requerida
        public required decimal PorcentajeComision { get; set; }  // Propiedad requerida
    }
}
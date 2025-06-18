using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComisionesVentas.Models
{
    public class Regla
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal MontoMinimo { get; set; }
        public decimal MontoMaximo { get; set; }
        [Required]
        public decimal PorcentajeComision { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
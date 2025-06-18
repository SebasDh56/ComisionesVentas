using ComisionesVentas.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace ComisionesVentas.Models
{
    public class Venta
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int VendedorId { get; set; }
        public virtual Vendedor Vendedor { get; set; }
        [Required]
        public DateTime Fecha { get; set; }
        [Required]
        public decimal Monto { get; set; }
        [Required]
        public int ReglaId { get; set; }
        public virtual Regla Regla { get; set; }
    }
}
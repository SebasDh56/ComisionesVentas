using SalesCommissionApp.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComisionesVentas.Models
{
    public class Vendedor
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Venta> Ventas { get; set; }
    }
}
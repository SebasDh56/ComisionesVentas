﻿using System;
using System.Collections.Generic;

namespace ComisionesVentas.ViewModels
{
    public class CommissionViewModel
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? VendedorId { get; set; }
        public required List<VentaCommission> Ventas { get; set; } // Usamos 'required' para indicar que debe inicializarse
        public decimal TotalComision { get; set; }
    }

    public class VentaCommission
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string VendedorNombre { get; set; }
        public decimal PorcentajeComision { get; set; }
        public decimal Comision { get; set; }
    }
}
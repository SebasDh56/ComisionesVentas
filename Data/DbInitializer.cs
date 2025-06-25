using ComisionesVentas.Models;

namespace ComisionesVentas.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SalesDbContext context)
        {
            // Verificar si ya hay datos (evitar duplicados)
            if (context.Vendedores.Any()) return;

            // Insertar Vendedores
            var vendedores = new Vendedor[]
            {
                new Vendedor { Nombre = "Ana Gomez", Email = "ana@example.com" },
                new Vendedor { Nombre = "Carlos Ruiz", Email = "carlos@example.com" },
                new Vendedor { Nombre = "María López", Email = "maria@example.com" },
                new Vendedor { Nombre = "Pedro Sánchez", Email = "pedro@example.com" },
                new Vendedor { Nombre = "Lucía Martínez", Email = "lucia@example.com" }
            };
            context.Vendedores.AddRange(vendedores);
            context.SaveChanges();

            // Insertar Reglas
            var reglas = new Regla[]
            {
                new Regla { MontoMinimo = 0, MontoMaximo = 1000, PorcentajeComision = 5 },
                new Regla { MontoMinimo = 1001, MontoMaximo = 5000, PorcentajeComision = 10 },
                new Regla { MontoMinimo = 5001, MontoMaximo = 999999, PorcentajeComision = 15 }
            };
            context.Reglas.AddRange(reglas);
            context.SaveChanges();

            // Insertar 20 Ventas
            var ventas = new Venta[]
            {
                new Venta { VendedorId = 1, Fecha = new DateTime(2025, 6, 1), Monto = 500, ReglaId = 1 },
                new Venta { VendedorId = 1, Fecha = new DateTime(2025, 6, 2), Monto = 1200, ReglaId = 2 },
                new Venta { VendedorId = 1, Fecha = new DateTime(2025, 6, 3), Monto = 6000, ReglaId = 3 },
                new Venta { VendedorId = 2, Fecha = new DateTime(2025, 6, 4), Monto = 300, ReglaId = 1 },
                new Venta { VendedorId = 2, Fecha = new DateTime(2025, 6, 5), Monto = 2000, ReglaId = 2 },
                new Venta { VendedorId = 2, Fecha = new DateTime(2025, 6, 6), Monto = 7000, ReglaId = 3 },
                new Venta { VendedorId = 3, Fecha = new DateTime(2025, 6, 7), Monto = 800, ReglaId = 1 },
                new Venta { VendedorId = 3, Fecha = new DateTime(2025, 6, 8), Monto = 3500, ReglaId = 2 },
                new Venta { VendedorId = 3, Fecha = new DateTime(2025, 6, 9), Monto = 5500, ReglaId = 3 },
                new Venta { VendedorId = 4, Fecha = new DateTime(2025, 6, 10), Monto = 400, ReglaId = 1 },
                new Venta { VendedorId = 4, Fecha = new DateTime(2025, 6, 11), Monto = 1800, ReglaId = 2 },
                new Venta { VendedorId = 4, Fecha = new DateTime(2025, 6, 12), Monto = 8000, ReglaId = 3 },
                new Venta { VendedorId = 5, Fecha = new DateTime(2025, 6, 13), Monto = 900, ReglaId = 1 },
                new Venta { VendedorId = 5, Fecha = new DateTime(2025, 6, 14), Monto = 2500, ReglaId = 2 },
                new Venta { VendedorId = 5, Fecha = new DateTime(2025, 6, 15), Monto = 6500, ReglaId = 3 },
                new Venta { VendedorId = 1, Fecha = new DateTime(2025, 6, 16), Monto = 700, ReglaId = 1 },
                new Venta { VendedorId = 2, Fecha = new DateTime(2025, 6, 16), Monto = 3000, ReglaId = 2 },
                new Venta { VendedorId = 3, Fecha = new DateTime(2025, 6, 17), Monto = 7500, ReglaId = 3 },
                new Venta { VendedorId = 4, Fecha = new DateTime(2025, 6, 17), Monto = 1000, ReglaId = 1 },
                new Venta { VendedorId = 5, Fecha = new DateTime(2025, 6, 17), Monto = 4500, ReglaId = 2 }
            };
            context.Ventas.AddRange(ventas);
            context.SaveChanges();
        }
    }
}
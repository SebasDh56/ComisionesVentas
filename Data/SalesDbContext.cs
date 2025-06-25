using ComisionesVentas.Models;
using Microsoft.EntityFrameworkCore;

namespace ComisionesVentas.Data
{
    public class SalesDbContext : DbContext
    {
        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options)
        {
        }

        public DbSet<Vendedor> Vendedores { get; set; }
        public DbSet<Regla> Reglas { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurar relaciones y claves primarias/foráneas
            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Vendedor)
                .WithMany()
                .HasForeignKey(v => v.VendedorId);

            modelBuilder.Entity<Venta>()
                .HasOne(v => v.Regla)
                .WithMany()
                .HasForeignKey(v => v.ReglaId);

            // Opcional: Asegurar que las claves primarias sean auto-incrementales (si no están configuradas en los modelos)
            modelBuilder.Entity<Vendedor>().Property(v => v.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Regla>().Property(r => r.Id).ValueGeneratedOnAdd();
            modelBuilder.Entity<Venta>().Property(v => v.Id).ValueGeneratedOnAdd();
        }
    }
}
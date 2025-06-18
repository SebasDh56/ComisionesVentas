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
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Regla> Reglas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vendedor>()
                .HasMany(v => v.Ventas)
                .WithOne(v => v.Vendedor)
                .HasForeignKey(v => v.VendedorId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Regla>()
                .HasMany(r => r.Ventas)
                .WithOne(v => v.Regla)
                .HasForeignKey(v => v.ReglaId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
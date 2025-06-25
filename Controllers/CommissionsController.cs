using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ComisionesVentas.Data;
using ComisionesVentas.ViewModels;
using System.Linq;

namespace ComisionesVentas.Controllers
{
    public class CommissionsController : Controller
    {
        private readonly SalesDbContext _context;

        public CommissionsController(SalesDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            ViewBag.Vendedores = _context.Vendedores.ToList();
            return View(new CommissionViewModel { Ventas = new List<VentaCommission>() }); // Inicialización explícita
        }

        [HttpPost]
        public IActionResult Calculate(CommissionViewModel model)
        {
            var query = _context.Ventas
                .Include(v => v.Vendedor)
                .Include(v => v.Regla)
                .AsQueryable();

            if (model.StartDate.HasValue)
                query = query.Where(v => v.Fecha >= model.StartDate.Value);
            if (model.EndDate.HasValue)
                query = query.Where(v => v.Fecha <= model.EndDate.Value);
            if (model.VendedorId.HasValue)
                query = query.Where(v => v.VendedorId == model.VendedorId.Value);

            var ventas = query.ToList();
            model.Ventas = ventas.Select(v => new VentaCommission
            {
                VentaId = v.Id,
                Fecha = v.Fecha,
                Monto = v.Monto,
                VendedorNombre = v.Vendedor.Nombre,
                PorcentajeComision = v.Regla.PorcentajeComision,
                Comision = v.Monto * v.Regla.PorcentajeComision / 100
            }).ToList();

            model.TotalComision = model.Ventas.Sum(v => v.Comision);

            ViewBag.Vendedores = _context.Vendedores.ToList();
            return View("Index", model);
        }
    }
}
using System;
using System.Linq;
using VendasMVC.Models;

namespace VendasMVC.Data
{
    public class SeedingService
    {
        private VendasMVCContext _context;

        public SeedingService(VendasMVCContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Departamento.Any() ||
                _context.Vendedor.Any() ||
                _context.Vendas.Any())
            {
                return;
            }

            Departamento d1 = new Departamento(1, "Consórcio");
            Departamento d2 = new Departamento(2, "Financiamento");
            Departamento d3 = new Departamento(3, "Empréstimo");
            Departamento d4 = new Departamento(4, "Cartões");

            Vendedor v1 = new Vendedor(1, "Veronica", "veronica@financeira.com", 3000.0, new DateTime(1995, 4, 5), d1);
            Vendedor v2 = new Vendedor(2, "Sibele", "sibele@financeira.com", 3000.0, new DateTime(1990, 10, 22), d2);
            Vendedor v3 = new Vendedor(3, "Rosana", "rosana@financeira.com", 3000.0, new DateTime(1970, 7, 10), d3);
            Vendedor v4 = new Vendedor(4, "Jessica", "jessica@financeira.com", 3000.0, new DateTime(1992, 1, 13), d4);

            Vendas vv1 = new Vendas(1, new DateTime(2022, 8, 1), 120000.0, Models.Enums.StatusVenda.Faturado, v1);
            Vendas vv2 = new Vendas(2, new DateTime(2022, 8, 1), 80000.0, Models.Enums.StatusVenda.Faturado, v2);
            Vendas vv3 = new Vendas(3, new DateTime(2022, 8, 2), 20000.0, Models.Enums.StatusVenda.Faturado, v3);
            Vendas vv4 = new Vendas(4, new DateTime(2022, 8, 2), 12000.0, Models.Enums.StatusVenda.Faturado, v4);
            Vendas vv5 = new Vendas(5, new DateTime(2022, 8, 3), 100000.0, Models.Enums.StatusVenda.Faturado, v1);
            Vendas vv6 = new Vendas(6, new DateTime(2022, 8, 3), 50000.0, Models.Enums.StatusVenda.Faturado, v2);
            Vendas vv7 = new Vendas(7, new DateTime(2022, 8, 3), 10000.0, Models.Enums.StatusVenda.Faturado, v3);
            Vendas vv8 = new Vendas(8, new DateTime(2022, 8, 4), 3000.0, Models.Enums.StatusVenda.Faturado, v4);

            _context.Departamento.AddRange(d1, d2, d3, d4);
            _context.Vendedor.AddRange(v1, v2, v3, v4);
            _context.Vendas.AddRange(vv1, vv2, vv3, vv4, vv5, vv6, vv7, vv8);

            _context.SaveChanges();
        }
    }
}

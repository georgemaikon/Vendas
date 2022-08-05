using System.Collections.Generic;
using System.Linq;
using VendasMVC.Data;
using VendasMVC.Models;

namespace VendasMVC.Services
{
    public class VendedorService
    {
        private readonly VendasMVCContext _context;

        public VendedorService(VendasMVCContext context)
        {
            _context = context; 
        }

        public List<Vendedor> FindAll()
        {
            return _context.Vendedor.ToList();
        }
    }
}

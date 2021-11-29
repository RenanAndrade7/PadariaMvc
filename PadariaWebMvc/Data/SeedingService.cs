/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PadariaWebMvc.Models;

namespace PadariaWebMvc.Data
{
    public class SeedingService
    {
        private PadariaWebMvcContext _context;

        public SeedingService(PadariaWebMvcContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if(_context.Client.Any() || _context.Product.Any())
            {
                return; // Banco de dados ja foi populado
            }

            Product p1 = new Product(1, "Pao", 0.50); 

            Client c1 = new Client(1, "Renan", p1);

           // Vendas v1 = new Vendas(1, new DateTime(2021, 09, 14), 0.50, Models.Enums.VendasStatus.faturado, c1);

            _context.Product.AddRange(p1);
            _context.Client.AddRange(c1);
            // _context.Vendas.AddRange(v1);

            _context.SaveChanges();
        }
    }
}
*/
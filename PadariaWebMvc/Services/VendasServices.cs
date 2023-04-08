/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PadariaWebMvc.Data;
using PadariaWebMvc.Models;
using Microsoft.EntityFrameworkCore;

namespace PadariaWebMvc.Services
{
    public class VendasServices
    {
        private readonly PadariaWebMvcContext _context;

        public VendasServices(PadariaWebMvcContext context)
        {
            _context = context;
        }

        public void Insert(Vendas obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public List<Vendas> FindByDate(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Vendas select obj;
            if(minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }
            if(minDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            return result.Include(x => x.Client).Include(x => x.Client.Product).OrderByDescending(x => x.Date).ToList();
        }

        public List<IGrouping<Product, Vendas>> FindByDateGrouping(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Vendas select obj;
            if(minDate.HasValue)
            {
                result = result.Where(x => x.Date >= minDate.Value);
            }

            if(minDate.HasValue)
            {
                result = result.Where(x => x.Date <= maxDate.Value);
            }

            return result.Include(x => x.Client).Include(x => x.Client.Product).OrderByDescending(x => x.Date).GroupBy(x => x.Client.Product).ToList();
        }
    }
}
*/
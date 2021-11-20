using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PadariaWebMvc.Data;
using PadariaWebMvc.Models;

namespace PadariaWebMvc.Services
{
    public class ProductServices
    {
        private readonly PadariaWebMvcContext _context;

        public ProductServices(PadariaWebMvcContext context)
        {
            _context = context;
        }

        public List<Product> FindAll()
        {
            return _context.Product.ToList();
        }

    }
}

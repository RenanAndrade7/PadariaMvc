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

        public void Insert(Product obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Product FindById(int id)
        {
            return _context.Product.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Product.Find(id);
            _context.Product.Remove(obj);
            _context.SaveChanges();
        }
    }
}

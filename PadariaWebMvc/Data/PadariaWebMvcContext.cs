using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PadariaWebMvc.Models;

namespace PadariaWebMvc.Data
{
    public class PadariaWebMvcContext : DbContext
    {
        public PadariaWebMvcContext (DbContextOptions<PadariaWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Client { get; set; }
        public DbSet<Product> Product { get; set; }
        // public DbSet<Vendas> Vendas { get; set; }
    }
}

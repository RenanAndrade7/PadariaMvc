using System;
using System.Collections.Generic;
using System.Linq;

namespace PadariaWebMvc.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Email { get; set; }

        public Product Product  { get; set; }

        // public ICollection<Vendas> Vendas { get; set; } = new List<Vendas>();

        public Client()
        {

        }

        public Client(int id, string name, Product product)
        {
            Id = id;
            Name = name;
            Product = product;
        }
    }
}

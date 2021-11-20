using System.Collections.Generic;
using System;
using System.Linq;

namespace PadariaWebMvc.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public double Valor { get; set; }
        public ICollection<Client> Client{ get; set; } = new List<Client>();

        public Product(int id, string name, double valor)
        {
            Id = id;
            Name = name;
            Valor = valor;
        }


        /* public ICollection<Vendas> Vendas { get; set; } = new List<Vendas>();

        public void AddVendas(Vendas vs)
        {
            Vendas.Add(vs);
        }

        public void RemoverVendas(Vendas vs)
        {
            Vendas.Remove(vs);
        }

        public double TotalVendas(DateTime inicio, DateTime final)
        {
            return Vendas.Where(vs => vs.Date >= inicio && vs.Date <= final).Sum(vs => vs.Quantia);
        }

        public Product()
        {

        }

        public Product(int id, string name)
        {
            Id = id;
            Name = name;
        } */

    }
}

/* using System;
using System.Linq;
using PadariaWebMvc.Models.Enums;

namespace PadariaWebMvc.Models
{
    public class Vendas
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double  Quantia { get; set; }
        public VendasStatus Status { get; set; }

        public Client Client { get; set; }

        public Vendas()
        {

        }

        public Vendas(int id, DateTime date, double quantia, VendasStatus status, Client client)
        {
            Id = id;
            Date = date;
            Quantia = quantia;
            Status = status;
            Client = client;
        }
    }
} */

/* using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadariaWebMvc.Models.ViewModels
{
    public class VendasFormViewModel
    {
            public ICollection<Client> Clients { get; set; }
            public int Client { get; set; }
            public DateTime DateVendas { get; set; }
            public int Status { get; set; }
            public double Quantia { get; set; }
            public ICollection<ItemEnumStatus> VendasStatus { get; set; }
        }

        public class ItemEnumStatus
        {
            public int Indice { get; set; }
            public string Texto { get; set; }
        }
    }

*/
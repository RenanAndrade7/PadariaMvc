using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PadariaWebMvc.Models.ViewModels
{
    public class ClientProductformViewModel
    {
        public Product Product { get; set; }
        public Client Client { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}

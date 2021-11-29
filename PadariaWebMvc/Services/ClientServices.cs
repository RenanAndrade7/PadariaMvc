﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PadariaWebMvc.Data;
using PadariaWebMvc.Models;

namespace PadariaWebMvc.Services
{
    public class ClientServices
    {
        private readonly PadariaWebMvcContext _context;

        public ClientServices(PadariaWebMvcContext context)
        {
            _context = context;
        }

        public List<Client> FindAll()
        {
            return _context.Client.OrderBy(x => x.Name).ToList();
        }

    }
}

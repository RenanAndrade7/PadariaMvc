using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PadariaWebMvc.Services;

namespace PadariaWebMvc.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductServices _productServices;

        public ProductsController(ProductServices productServices)
        {
            _productServices = productServices;
        }


        public IActionResult Index()
        {
            var list = _productServices.FindAll();
            return View(list);
        }
    }
}

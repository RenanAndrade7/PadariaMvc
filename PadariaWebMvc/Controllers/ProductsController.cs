using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PadariaWebMvc.Services;
using PadariaWebMvc.Models;
using PadariaWebMvc.Data;
using PadariaWebMvc.Models.ViewModels;

namespace PadariaWebMvc.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ProductServices _productServices;
        private readonly ClientServices _clientServices;

        public ProductsController(ProductServices productServices, ClientServices clientServices)
        {
            _productServices = productServices;
            _clientServices = clientServices;
        }


        public IActionResult Index()
        {
            var list = _productServices.FindAll();
            return View(list);
        }

        public IActionResult Create() // Controlador Create que irá chamar a View Create
        {
            return View();
        }

        
        [HttpPost] // Mesmo controlador Create anterior mas esse é para atualizar,
                   // gravar informação no Banco de Dados
        [ValidateAntiForgeryToken] // Proteção para não invadirem a página
        public IActionResult Create(Product product)
        {
            _productServices.Insert(product);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var obj = _productServices.FindById(id.Value);
            if(obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _productServices.Remove(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _productServices.FindById(id.Value);
            if (obj == null)
            {
                return NotFound();
            }

            return View(obj);
        }

    }
}

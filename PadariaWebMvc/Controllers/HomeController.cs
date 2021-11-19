using Microsoft.AspNetCore.Mvc;
using PadariaWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace PadariaWebMvc.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Atendemos diversos tipos de produtos a sua escolha.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Pagina de Contatos";
            ViewData["Email"] = "padaria@gmail.com";
            ViewData["Telefone"] = "996442641";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

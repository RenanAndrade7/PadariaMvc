/* using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using PadariaWebMvc.Services;
using PadariaWebMvc.Models.Enums;
using PadariaWebMvc.Models;
using PadariaWebMvc.Models.ViewModels;


namespace PadariaWebMvc.Controllers
{
    public class VendasController : Controller
    {
        private readonly VendasServices _vendasServices;
        private readonly ClientServices _clientServices;

        public VendasController(VendasServices vendasServices, ClientServices clientServices)
        {
            _vendasServices = vendasServices;
            _clientServices = clientServices;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            var list =  _clientServices.FindAll();
            var obj = new VendasFormViewModel
            {
                Clients = list,
                VendasStatus = Enum.GetValues(typeof(VendasStatus)).Cast<VendasStatus>().Select(en => new ItemEnumStatus
                {
                    Indice = (int)en,
                    Texto = en.ToString()
                }).ToList()
            };
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(VendasFormViewModel venda)
        {
            var objVenda = new Vendas
            {
                Status = (VendasStatus)venda.Status,
                Date = venda.DateVendas,
                Client = _clientServices.FindById(venda.Client),
                Quantia = venda.Quantia
            };

            _vendasServices.Insert(objVenda);
            return RedirectToAction(nameof(Index));
        }



        public IActionResult SimpleSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = _vendasServices.FindByDate(minDate, maxDate);
            return View(result);
        }
        public IActionResult GroupingSearch(DateTime? minDate, DateTime? maxDate)
        {
            if (!minDate.HasValue)
            {
                minDate = new DateTime(DateTime.Now.Year, 1, 1);
            }
            if (!maxDate.HasValue)
            {
                maxDate = DateTime.Now;
            }
            ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");
            var result = _vendasServices.FindByDateGrouping(minDate, maxDate);
            return View(result);
        }
    }
}
*/
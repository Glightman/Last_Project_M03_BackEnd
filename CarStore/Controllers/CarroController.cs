using CarStore.Models;
using CarStore.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Controllers
{
    public class CarroController : Controller
    {
        ICarroService service;
        CarroSqlService sqlService;
        CarroStaticService staticService;
        public CarroController(ICarroService service, CarroSqlService sqlService, CarroStaticService staticService)
        {
            this.service = service;
            this.sqlService = sqlService;
            this.staticService = staticService;
        }

        public IActionResult Index(string busca, string servico = "Serviço SQL", bool ordenar = false)
        {
            if (servico == "Serviço Estático") this.service = staticService;
            if (servico == "Serviço SQL") this.service = sqlService;
            return View(service.getAll(busca, ordenar));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Carro carro)
        {
            if (!ModelState.IsValid) return View(carro);

            if (service.create(carro))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(carro);
            }

        }
        public IActionResult Read (int? id)
        {
            Carro carro = service.get(id);
            return carro != null ?
                View(carro) :
                RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            Carro carro = service.get(id);
            return carro != null ?
                View(carro) :
                RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Carro carro)
        {
            if (!ModelState.IsValid) return View(carro);

            if (service.update(carro))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(carro);
            }

        }
        public IActionResult Confirm(int? id)
        {
            if (service.delete(id))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }
    }
}

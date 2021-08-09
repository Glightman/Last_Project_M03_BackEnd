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
        public CarroController(ICarroService service)
        {
            this.service = service;
        }

        public IActionResult Index(string busca, bool ordenar = false)
        {
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

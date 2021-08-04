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
        CarroSqlService SqlService;
        CarroStaticService serviceStatic;
        public CarroController(ICarroService service, CarroSqlService SqlService, CarroStaticService serviceStatic)
        {
            this.service = service;
            this.SqlService = SqlService;
            this.serviceStatic = serviceStatic;
        }

        public IActionResult Index(string busca, bool ordenar = false)
        {
            return View(SqlService.getAll(busca, ordenar));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Carro carro)
        {
            if (service.create(carro))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(carro);
            }

        }
    }
}

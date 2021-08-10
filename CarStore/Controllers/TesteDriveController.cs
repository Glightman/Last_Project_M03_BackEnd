using CarStore.Models;
using CarStore.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Controllers
{
    public class TesteDriveController : Controller
    {
        ITesteDriveService service;
        public TesteDriveController(ITesteDriveService service)
        {
            this.service = service;
        }

        public IActionResult Index()
        {
            return View(service.getAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TesteDrive teste)
        {
            if (!ModelState.IsValid) return View(teste);

            if (service.create(teste))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(teste);
            }

        }
        public IActionResult Read (int? id)
        {
            TesteDrive teste = service.get(id);
            return teste != null ?
                View(teste) :
                RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            TesteDrive teste = service.get(id);
            return teste != null ?
                View(teste) :
                RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(TesteDrive teste)
        {
            if (!ModelState.IsValid) return View(teste);

            if (service.update(teste))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(teste);
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

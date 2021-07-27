using CarStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Controllers
{
    public class CarroController : Controller
    {
        public IActionResult Index(int id)
        {
            List<Carro> carros = id == 0 ? getCars() : getCars().FindAll(x => x.id == id);
            return View(carros);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Carro c)
        {
            List<Carro> carros = getCars();
            c.id = carros.Count() + 1;
            carros.Add(c);
            ViewBag.lista = carros;
            return View("Index");
        }
        public IActionResult Sucesso()
        {
            return View();
        }
        List<Carro> getCars()
        {
            List<Carro> listaCarros = new List<Carro>();
            listaCarros.Add(new Carro
            {
                id = 1,
                marca = "Chevrolet",
                modelo = "Onix",
                ano = 2018,
                preco = 52000,
                url = "data:image/jpeg;base64,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",
                descricao = "Carro Semi novo. unico dono"
            });
            listaCarros.Add(new Carro
            {
                id = 2,
                marca = "Chevrolet",
                modelo = "S10",
                ano = 2018,
                preco = 150000,
                url = "https://production.autoforce.com/uploads/version/profile_image/5100/model_main_comprar-4x4-2-8-diesel-lt-pacote-r7n_32f5a22372.png",
                descricao = "Carro Semi novo. unico dono"
            });
            listaCarros.Add(new Carro
            {
                id = 3,
                marca = "Ford",
                modelo = "Ká Sedan",
                ano = 2016,
                preco = 43000,
                url = "https://static.virgola.com.br/images/b1668214c76e31fd640141319ce70fc220f305712d47a24fa61e20d54e937017.png",
                descricao = "Carro Semi novo. unico dono"
            });
            listaCarros.Add(new Carro
            {
                id = 4,
                marca = "Ford",
                modelo = "Eco Sport",
                ano = 2020,
                preco = 87000,
                url = "https://production.autoforce.com/uploads/version/profile_image/3012/comprar-freestyle-1-5-at_839776741a.png",
                descricao = "Carro Semi novo. unico dono"
            });
            listaCarros.Add(new Carro
            {
                id = 5,
                marca = "Fiat",
                modelo = "Strada",
                ano = 2019,
                preco = 74500,
                url = "https://revistacarro.com.br/wp-content/uploads/2018/05/2.png",
                descricao = "Carro Semi novo. unico dono"
            });
            listaCarros.Add(new Carro
            {
                id = 6,
                marca = "Fiat",
                modelo = "Argo",
                ano = 2021,
                preco = 68730,
                url = "https://production.autoforce.com/uploads/version/profile_image/5352/comprar-1-0_8a75988860.png",
                descricao = "Carro NOVO"
            });
            listaCarros.Add(new Carro
            {
                id = 7,
                marca = "VolksWagen",
                modelo = "Voyage",
                ano = 2018,
                preco = 52000,
                url = "https://importadora.ams3.digitaloceanspaces.com/2018/08/VoyageAutomtico.png",
                descricao = "Carro Semi novo. unico dono"
            });
            listaCarros.Add(new Carro
            {
                id = 8,
                marca = "VolksWagen",
                modelo = "Amarok",
                ano = 2021,
                preco = 210000,
                url = "https://static.virgola.com.br/images/c5d9d87daed6bbe95f294eeed94ed875209d03da959a3ced08bdd74f604ec0a5.png",
                descricao = "Carro NOVO"
            });
            listaCarros.Add(new Carro
            {
                id = 9,
                marca = "Jeep",
                modelo = "Renegade",
                ano = 2018,
                preco = 91200,
                url = "https://production.autoforce.com/uploads/version/profile_image/1463/comprar-1-8-flex-at-pcd_a4a28811f9.png",
                descricao = "Carro Semi novo. unico dono"
            });
            listaCarros.Add(new Carro
            {
                id = 10,
                marca = "Toyota",
                modelo = "Hilux SW4",
                ano = 2021,
                preco = 283000,
                url = "http://www.planetcarsz.com/assets/uploads/TOYOTA%20FORTUNER%202021%2003.jpg",
                descricao = "Carro Novo"
            });
            return listaCarros;
        }
    }
}

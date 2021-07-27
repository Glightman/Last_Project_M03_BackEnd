using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Models
{
    public class Carro
    {
        [Display(Name = "#")]
        public int id { get; set; }

        [Display(Name = "Marca")]
        public string marca { get; set; }

        [Display(Name = "Modelo")]
        public string modelo { get; set; }

        [Display(Name = "Preço R$")]
        public double preco { get; set; }
        
        [Display(Name = "Ano - Modelo")]
        public int ano { get; set; }

        [Display(Name = "Foto_URL")]
        public string url { get; set; }

        [Display(Name = "Descrição")]
        public string descricao { get; set; }
    }
}

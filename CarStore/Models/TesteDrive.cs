 using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Models
{
    public class TesteDrive
    {
        [Display (Name = "#")]
        public int id { get; set; }

        [Display(Name = "Nome completo: ")]
        [Required(ErrorMessage = "Nome completo é obrigatório")]
        public string nome { get; set; }

        [Display(Name = "Número do celular/WhatsApp: ")]
        [Required(ErrorMessage = "Número de Telefone é obrigatório")]
        public int celular { get; set; }

        [Display(Name = "Tipo de negociação: ")]
        public string tipo { get; set; }

        [Display(Name = "Carro para teste: ")]
        [Required(ErrorMessage = "Carro para teste é obrigatório")]
        public int carroid { get; set; }
        public Carro carro { get; set; }
    }
}

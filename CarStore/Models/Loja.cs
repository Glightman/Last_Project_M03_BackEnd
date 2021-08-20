using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarStore.Models
{
    public class Loja
    {
        [Display(Name = "#")]
        public int id { get; set; }

        [Required(ErrorMessage = "Informe o nome da loja")]
        [Display(Name = "Nome da loja: ")]
        public string nome_loja { get; set; }

        [Required(ErrorMessage = "Informe o endereço da loja seguido do bairro")]
        [Display(Name = "Endereço: ")]
        public string endereco { get; set; }
    }
}

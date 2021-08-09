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

        [Required(ErrorMessage = "Informe a marca do carro")]
        [Display(Name = "Marca")]
        public string marca { get; set; }

        [Required(ErrorMessage = "Informe o modelo do carro")]
        [Display(Name = "Modelo")]
        public string modelo { get; set; }

        [Required(ErrorMessage = "Informe o valor do carro")]
        [Display(Name = "Preço R$")]
        public double preco { get; set; }

        [Required(ErrorMessage = "Informe o ano do carro")]
        [Display(Name = "Ano - Modelo")]
        public int ano { get; set; }

        [Required(ErrorMessage = "Informe o endeeço URL da imagem do carro")]
        [Display(Name = "Foto_URL do carro")]
        public string url1 { get; set; }

        [Display(Name = "Descrição")]
        public string descricao { get; set; }
    }
}

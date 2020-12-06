using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraWeb.Models
{
    public class Garagem : BaseModel
    {
        public string Nome { get; set; }
        //Logradouro=rua
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string Uf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Cep { get; set; }
    }
}

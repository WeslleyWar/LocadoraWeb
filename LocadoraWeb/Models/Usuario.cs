using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraWeb.Models 
{
    public class Usuario : IdentityUser
    {
        public Usuario()
        {
            CriadoEm = DateTime.Now;
            
        }

        [Required(ErrorMessage = "Campo obrigatório!!")]
        public string Nome { get; set; }

        public string Genero { get; set; }
        [Display(Name = "Profissão")]
        public string Profissao { get; set; }

        [Display(Name = "Ano de Nascimento")]
        [Required(ErrorMessage = "Campo obrigatório!!")]
        public DateTime AnoNasc { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!!")]
        public string Cnh { get; set; }
        [Required(ErrorMessage = "Campo obrigatório!!")]
        public string Cpf { get; set; }
        public string Telefone { get; set; }
        [Display(Name = "Criado Em")]
        public DateTime CriadoEm { get; set; }

        [Display(Name = "CEP")]
        public string Cep { get; set; }

        [Display(Name = "Rua")]
        public string Logradouro { get; set; }

        [Display(Name = "Cidade")]
        public string Localidade { get; set; }

        [Display(Name = "Bairro")]
        public string Bairro { get; set; }

        [Display(Name = "Estado")]
        public string Uf { get; set; }
        [Display(Name = "Número")]
        public string Numero { get; set; }
    }
}

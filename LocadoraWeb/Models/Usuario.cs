using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraWeb.Models 
{
    public class Usuario : IdentityUser
    {
        public Usuario() => CriadoEm = DateTime.Now;

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Genero { get; set; }
        public string Profissao { get; set; }
        public DateTime AnoNasc { get; set; }
        public string Cnh { get; set; }
        public string Cpf { get; set; }
        public string Cep { get; set; }
        public string Telefone { get; set; }
        public DateTime CriadoEm { get; set; }
    }
}

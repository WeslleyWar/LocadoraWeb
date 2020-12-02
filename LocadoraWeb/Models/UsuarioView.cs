using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraWeb.Models
{
    [Table("Usuarios")]
    public class UsuarioView : BaseModel
    {
        //Dados da Conta
        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Campo obrigatório!!")]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Campo obrigatório!!")]
        public string Senha { get; set; }

        [Display(Name = "Confirmar senha")]
        [Required(ErrorMessage = "Campo obrigatório!!")]
        [NotMapped]
        [Compare("Senha", ErrorMessage = "As senhas não coincidem!")]
        public string ConfirmacaoSenha { get; set; }

        //Dados do Endereço
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

        //Dados Pessoais
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

    }
}

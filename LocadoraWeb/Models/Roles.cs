using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraWeb.Models
{
    public class Roles : BaseModel
    {
        [Display(Name = "Nome da Role")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        public string RoleNome { get; set; }
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }
    }
}

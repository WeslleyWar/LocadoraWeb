using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraWeb.Models
{
    [Table("Clientes")]
    public class Cliente : BaseModel
    {
        public string Nome { get; set; }
        public int CPF { get; set; }
        public string Email { get; set; }
        public string Endereço { get; set; }
        public int Habilitação { get; set; }
        public string Categoria { get; set; }
        public int Telefone { get; set; }
     
    
    }
}

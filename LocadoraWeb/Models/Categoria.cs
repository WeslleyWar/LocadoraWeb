using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraWeb.Models
{
    [Table("Categorias")]
    public class Categoria : BaseModel
    {
        [Display(Name = "Nome :")]
        public string Nome { get; set; }
        [Display(Name = "Valor diária: ")]
        public double valorDiaria { get; set; }
        [Display(Name = "Descrição: ")]
        public string Descricao { get; set; }

        public List<Veiculo> Veiculos { get; set; }

       

    }
}

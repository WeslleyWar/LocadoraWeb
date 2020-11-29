using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraWeb.Models
{
    [Table("Veiculos")]
    public class Veiculo : BaseModel
    {
        //Required é uma tag para setar o atributo como necessario, não pode ser nulo, obrigatorio que declare um
        //valor para o mesmo. A tag deve ser colocada na linha acima do atributo.
        [Required(ErrorMessage= "Campo obrigatório!")]
        public string Marca { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(7, ErrorMessage = "Mínimo 7 caracteres!")]
        [MaxLength(8, ErrorMessage = "Maximo 8 caracteres!")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Renavan { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string TipoCategoria { get; set; }

        public string TipoCombustivel { get; set; }
        public string Cor { get; set; }
        public int QntdPortas { get; set; }
        public int Ano { get; set; }
        public double Potencia { get; set; }
        public string Imagem { get; set; }

        public Categoria Categoria { get; set; }
        [ForeignKey("CategoriaId")]
        public int CategoriaId { get; set; }
    }
}

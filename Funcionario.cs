using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraWeb.Models
{
    [Table("Funcionarios")]
    public class Funcionario : BaseModel
    {
        //string txtMarca, string txtModelo, string txtPlaca,
        //    string txtRenavan, string txtTipoCategoria, string txtTipoCombustivel, string txtCor,
        //    int txtQntdPortas, int txtAno, double txtPotencia
        public string Nome { get; set; }
        public string Data { get; set; }
        public string Sexo { get; set; }
        public string Cpf { get; set; }
        
    }
}

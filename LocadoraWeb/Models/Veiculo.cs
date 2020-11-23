using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraWeb.Models
{
    [Table("Veiculos")]
    public class Veiculo : BaseModel
    {
        //string txtMarca, string txtModelo, string txtPlaca,
        //    string txtRenavan, string txtTipoCategoria, string txtTipoCombustivel, string txtCor,
        //    int txtQntdPortas, int txtAno, double txtPotencia
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Renavan { get; set; }
        public string TipoCategoria { get; set; }
        public string TipoCombustivel { get; set; }
        public string Cor { get; set; }
        public int QntdPortas { get; set; }
        public int Ano { get; set; }
        public double Potencia { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraWeb.Models
{
    public class ItemLocacao : BaseModel
    {
        //Veiculo
        public ItemLocacao() => Veiculo = new Veiculo();
        public Veiculo Veiculo { get; set; }
        public int QntdDiasLocacao { get; set; }
        public double Preco { get; set; }
        public string CarrinhoId { get; set; }


    }
}

using LocadoraWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraWeb.DAL
{
    public class ItemLocacaoDAO
    {
        private readonly Context _context;


        public ItemLocacaoDAO(Context context) => _context = context;

        public List<ItemLocacao> ListarPorCarrinhoId(string id) => _context.ItensLocacao.
            Include(x => x.Veiculo.Categoria).Where(x => x.CarrinhoId == id).ToList();

        public void Cadastrar(ItemLocacao item)
        {
            _context.ItensLocacao.Add(item);
            _context.SaveChanges();
        }



    }
}

//public List<ItemLocacao> Listar() => _context.Categorias.ToList();
//public ItemLocacao BuscarPorId(int id) => _context.Categorias.Find(id);
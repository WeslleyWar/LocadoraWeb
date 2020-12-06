using LocadoraWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraWeb.DAL
{
    public class CategoriaDAO
    {
        private readonly Context _context;

        public CategoriaDAO(Context context) => _context = context;

        public List<Categoria> Listar() => _context.Categorias.ToList();

        public Categoria BuscarPorId(int id) => _context.Categorias.Find(id);

        public bool Cadastrar(Categoria categoria)
        {
            if (BuscarPorId(categoria.Id) == null)
            {
                //Retirar linha de baixo
                //veiculo.Potencia = veiculo.Categoria.valorDiaria;
                _context.Categorias.Add(categoria);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public void Remover(int id)
        {
            _context.Categorias.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
    }
}

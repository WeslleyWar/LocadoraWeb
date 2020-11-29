using LocadoraWeb.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraWeb.DAL
{
    public class VeiculoDAO
    {
        private readonly Context _context;

        public VeiculoDAO(Context context) => _context = context;

        public List<Veiculo> Listar() => _context.Veiculos.Include(x => x.Categoria).ToList();

        public List<Veiculo> ListarPorCategoria(int id) => _context.Veiculos.Where(x => x.CategoriaId == id).ToList();
        

        public Veiculo BuscarPorId(int id) => _context.Veiculos.Find(id);
        public Veiculo BuscarPorPlaca(string placa) => _context.Veiculos.FirstOrDefault(x => x.Placa == placa);

        public bool Cadastrar(Veiculo veiculo)
        {
            if(BuscarPorPlaca(veiculo.Placa) == null)
            {
                //Retirar linha de baixo
                //veiculo.Potencia = veiculo.Categoria.valorDiaria;
                _context.Veiculos.Add(veiculo);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public void Remover(int id)
        {
            _context.Veiculos.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
        public void Alterar(Veiculo veiculo)
        {
            _context.Veiculos.Update(veiculo);
            _context.SaveChanges();
        }

        public List<Veiculo> BuscarPorCategoria(int id) => _context.Veiculos.Where(x => x.CategoriaId == id).ToList();
        

    }
}

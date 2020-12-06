using LocadoraWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocadoraWeb.DAL
{
    public class GaragemDAO
    {
        private readonly Context _context;

        public GaragemDAO(Context context) => _context = context;

        public List<Garagem> Listar() => _context.Garagem.ToList();

        public Garagem BuscarPorId(int id) => _context.Garagem.Find(id);

        public bool Cadastrar(Garagem garagem)
        {
            if (BuscarPorId(garagem.Id) == null)
            {
                _context.Garagem.Add(garagem);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public void Remover(int id)
        {
            _context.Garagem.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }

    }
}

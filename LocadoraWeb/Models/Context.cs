using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LocadoraWeb.Models;

namespace LocadoraWeb.Models
{
    public class Context : IdentityDbContext<Usuario>
    {
        public Context(DbContextOptions options): base(options) { }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<ItemLocacao> ItensLocacao { get; set; }
        public DbSet<UsuarioView> Usuarios { get; set; }
        public DbSet<Garagem> Garagem { get; set; }
       
        //public DbSet<Usuario> Usuarioss { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using ToNaReserva.Mapeamentos;

namespace Models
{
    public class Contexto : DbContext
    {
        public DbSet<Usuario>? Usuarios {get; set;}
        public DbSet<Posto>? Postos { get; set; }
        public DbSet<Produto>? Produtos { get; set; }
        public DbSet<Avaliacao>? Avaliacoes { get; set; }

        public Contexto(DbContextOptions<Contexto> opcoes): base(opcoes)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder){
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UsuarioMap());
            builder.ApplyConfiguration(new PostoMap());
            builder.ApplyConfiguration(new ProdutoMap());
            builder.ApplyConfiguration(new AvaliacaoMap());
        }
    }
}
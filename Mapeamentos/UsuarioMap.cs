using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
namespace ToNaReserva.Mapeamentos
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.HasKey(u => u.id);
            builder.Property(u => u.nome).HasMaxLength(50).IsRequired();
            builder.Property(u => u.email).HasMaxLength(50).IsRequired();
            builder.Property(u => u.cpfcnpj).IsRequired();
            builder.Property(u => u.cep).IsRequired();
            builder.Property(u => u.cidade).IsRequired();
            builder.Property(u => u.bairro).IsRequired();
            builder.Property(u => u.rua).IsRequired();
            builder.Property(u => u.numero).IsRequired();
            builder.Property(u => u.senha).IsRequired();
            builder.Property(u => u.tipo);

            builder.ToTable("usuarios");
        }
    }
}
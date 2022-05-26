using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace ToNaReserva.Mapeamentos
{
    public class PostoMap : IEntityTypeConfiguration<Posto>
    {
        public void Configure(EntityTypeBuilder<Posto> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.nome).HasMaxLength(50).IsRequired();
            builder.Property(p => p.telefone);
            builder.Property(p => p.pais).IsRequired();
            builder.Property(p => p.cidade).IsRequired();
            builder.Property(p => p.cep).IsRequired();
            builder.Property(p => p.bairro).IsRequired();
            builder.Property(p => p.rua).IsRequired();
            builder.Property(p => p.numero).IsRequired();
            builder.Property(p => p.gasolina);
            builder.Property(p => p.diesel);
            builder.Property(p => p.etanol);
            builder.Property(p => p.estrelas);
            builder.Property(p => p.usuarioid);

            //builder.HasMany(p => p.produtos).WithOne(p => p.posto);
            builder.ToTable("postos");
        }
    }
}
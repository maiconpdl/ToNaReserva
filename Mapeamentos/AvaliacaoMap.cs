using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace ToNaReserva.Mapeamentos
{
    public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
    {
        public void Configure(EntityTypeBuilder<Avaliacao> builder)
        {
            builder.HasKey(a => a.id);
            builder.Property(a => a.comentario).IsRequired();
            builder.Property(a => a.estrelas).IsRequired();

          //  builder.HasOne(a => a.posto).WithMany(a => a.avaliacoes).HasForeignKey(a => a.postoid).IsRequired();

            builder.ToTable("avaliacoes");
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace ToNaReserva.Mapeamentos
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.id);
            builder.Property(p => p.nome);
            builder.Property(p => p.categoria);
            builder.Property(p => p.valor);
            builder.Property(p => p.quantidade);
            builder.Property(p => p.datacadastro);
            builder.Property(p => p.postoid);
            //builder.HasOne(p => p.posto).WithMany(p => p.produtos).HasForeignKey(p => p.postoid).IsRequired();

            builder.ToTable("produtos");
        }
    }
}
using Entregas.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entregas.Data.Mapping
{
    public class ProdutosEntregaMapping : IEntityTypeConfiguration<ProdutosEntrega>
    {
        public void Configure(EntityTypeBuilder<ProdutosEntrega> builder)
        {
            builder.HasKey(pe => new { pe.EntregaId, pe.ProdutoId });

            builder.HasOne(pe => pe.Produto)
                .WithMany(p => p.Entregas)
                .HasForeignKey(pe => pe.ProdutoId)
                .IsRequired();

            builder.HasOne(pe => pe.Entrega)
                .WithMany(e => e.Produtos)
                .HasForeignKey(pe => pe.EntregaId)
                .IsRequired();

            builder.ToTable("ProdutosEntrega");
        }
    }
}

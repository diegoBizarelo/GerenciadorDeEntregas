using Entregas.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entregas.Data.Mapping
{
    public class ProdutoMapping : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasDefaultValueSql("NEWID()");

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(e => e.Descricao)
                .HasColumnType("varchar(500)");

            builder.ToTable("Produtos");
        }
    }
}

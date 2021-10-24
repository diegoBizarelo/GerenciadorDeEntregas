using Entregas.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entregas.Data.Mapping
{
    public class EstabelecimentoMapping : IEntityTypeConfiguration<Estabelecimento>
    {
        public void Configure(EntityTypeBuilder<Estabelecimento> builder)
        {
            builder.Property(e => e.Id);

            builder.Property(e => e.Id).HasDefaultValueSql("NEWID()");

            builder.Property(e => e.RazaoSocial)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(e => e.Cnpj)
                .IsRequired()
                .HasColumnType("varchar(15)");

            builder.HasMany(e => e.Produtos)
                .WithOne(e => e.Estabelecimento)
                .HasForeignKey(p => p.EstabelecimentoId);

            builder.HasMany(e => e.Entregas)
                .WithOne(e => e.Estabelecimento)
                .HasForeignKey(e => e.EstabelecimentoId);

            builder.ToTable("Estabelecimentos");
        }
    }
}

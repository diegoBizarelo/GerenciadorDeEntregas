using Entregas.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;
using System.Text;

namespace Entregas.Data.Mapping
{
    public class EntregadorMapping : IEntityTypeConfiguration<Entregador>
    {
        public void Configure(EntityTypeBuilder<Entregador> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasDefaultValueSql("NEWID()");

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(e => e.Transporte)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(e => e.Disponivel)
                .HasColumnType("bit");

            builder.HasMany(e => e.Entregas)
                .WithOne(e => e.Entregador)
                .HasForeignKey(e => e.EntregadorId);

            builder.ToTable("Entregadores");
        }
    }
}

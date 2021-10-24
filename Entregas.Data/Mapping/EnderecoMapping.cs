using Entregas.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entregas.Data.Mapping
{
    public class EnderecoMapping : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasDefaultValueSql("NEWID()");

            builder.Property(e => e.Bairro)
                .IsRequired()
                .HasColumnType("varchar(150)");

            builder.Property(e => e.CEP)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(e => e.Cidade)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(e => e.Complemento)
                .HasColumnType("varchar(200)");

            builder.Property(e => e.Logradouro)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(e => e.Numero)
                .IsRequired()
                .HasColumnType("varchar(10)");
            
            builder.Property(e => e.UF)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.ToTable("Enderecos");
        }
    }
}

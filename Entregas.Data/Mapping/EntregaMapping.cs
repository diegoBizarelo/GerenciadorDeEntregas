using Entregas.Dominio.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entregas.Data.Mapping
{
    public class EntregaMapping : IEntityTypeConfiguration<Entrega>
    {
        public void Configure(EntityTypeBuilder<Entrega> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).HasDefaultValueSql("NEWID()");

            builder.ToTable("Entregas");
        }
    }
}

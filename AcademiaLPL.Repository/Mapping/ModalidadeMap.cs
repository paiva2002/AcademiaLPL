using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AcademiaLPL.Domain.Entities;

namespace AcademiaLPL.Repository.Mapping
{
    public class ModalidadeMap : IEntityTypeConfiguration<Modalidade>
    {
        public void Configure(EntityTypeBuilder<Modalidade> builder)
        {
            builder.ToTable("Modalide");

            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(prop => prop.Descricao)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(prop => prop.Precomensal)
                .IsRequired()
                .HasColumnType("double");
        }

    }
}

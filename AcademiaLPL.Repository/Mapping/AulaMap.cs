using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using AcademiaLPL.Domain.Entities;

namespace AcademiaLPL.Repository.Mapping
{
    public class AulaMap : IEntityTypeConfiguration<Aula>
    {
        public void Configure(EntityTypeBuilder<Aula> builder)
        {
            // Define a chave primária
            builder.HasKey(a => a.Id);

            // Define as chaves estrangeiras
            builder.HasOne(a => a.Modalidade)  // Aula tem uma Modalidade
                .WithMany()                    // Modalidade pode estar em várias Aulas
                .HasForeignKey(a => a.IdModalidade); // Chave estrangeira

            builder.HasOne(a => a.Professor)  // Aula tem um Professor
                .WithMany()                   // Professor pode estar em várias Aulas
                .HasForeignKey(a => a.IdProfessor); // Chave estrangeira

            // Definição dos tipos de colunas
            builder.Property(a => a.DiaSemana)
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(a => a.HorarioInicio)
                .IsRequired()
                .HasColumnType("Time");

            builder.Property(a => a.HorarioFim)
                .IsRequired()
                .HasColumnType("Time");
        }
    }
}


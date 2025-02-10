using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AcademiaLPL.Domain.Entities;

namespace AcademiaLPL.Repository.Mapping
{
    public class AlunoModalidadeMap : IEntityTypeConfiguration<AlunoModalidade>
    {
        public void Configure(EntityTypeBuilder<AlunoModalidade> builder)
        {

            // Define as chaves estrangeiras
            builder.HasOne(a => a.Aluno)  // Aula tem uma Modalidade
                .WithMany()                    // Modalidade pode estar em várias Aulas
                .HasForeignKey(a => a.IdAluno); // Chave estrangeira
            
            builder.HasOne(a => a.Modalidade)  
                .WithMany()                  
                .HasForeignKey(a => a.IdModalidade); 

            builder.Property(am => am.DataInicio)
                .IsRequired()
                .HasColumnType("DateTime");
        }
    }
}

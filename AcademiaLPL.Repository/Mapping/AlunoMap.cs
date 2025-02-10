using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using AcademiaLPL.Domain.Entities;

namespace AcademiaLPL.Repository.Mapping
{
    public class AlunoMap : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            // Define o nome da tabela
            //builder.ToTable("amostradinho");

            // Define a chave primária
            builder.HasKey(prop => prop.Id);

            builder.Property(prop => prop.Nome)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(prop => prop.DataNascimento)
                .IsRequired()
                .HasColumnType("DateTime");
            builder.Property(prop => prop.Telefone)
                .IsRequired()
                .HasColumnType("varchar(15)");
            builder.Property(prop => prop.Email)
                .IsRequired()
                .HasColumnType("varchar(100)");
            builder.Property(prop => prop.DataMatricula)
                .IsRequired()
                .HasColumnType("DateTime");
        }
    }
}

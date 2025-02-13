using Microsoft.EntityFrameworkCore;
using AcademiaLPL.Domain.Entities;
using AcademiaLPL.Repository.Mapping;

namespace AcademiaLPL.Repository.Context
{
    public class MySqlContext : DbContext
    {
        public MySqlContext(DbContextOptions<MySqlContext> options) :
            base(options)
        {
            Database.EnsureCreated(); // Cria o banco caso não exista
        }
        public DbSet<Modalidade> Modalidades { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<AlunoModalidade> AlunoModalidades { get; set; }
        //public TimeSpan HorarioFim { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Modalidade>(new ModalidadeMap().Configure);
            modelBuilder.Entity<Professor>(new ProfessorMap().Configure);
            //modelBuilder.Entity<Aula>(new AulaMap().Configure);
            modelBuilder.Entity<AlunoModalidade>(new AlunoModalidadeMap().Configure);

            modelBuilder.Entity<Aula>()
            .Property(a => a.HorarioFim)
            .HasConversion(
            v => v.TimeOfDay,  // Converte DateTime para TimeSpan antes de salvar
            v => DateTime.Today.Add(v) // Converte TimeSpan para DateTime ao ler
            );

        }
    }
}

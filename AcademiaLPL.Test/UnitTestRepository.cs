using AcademiaLPL.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace AcademiaLPL.Test
{
    [TestClass]
    public class UnitTestRepository
    {
        public partial class MyDbContext : DbContext
        {
            public DbSet<Modalidade> Modalidades { get; set; }
            public DbSet<Professor> Professors { get; set; }
            public DbSet<Aluno> Alunos { get; set; }
            public DbSet<Aula> Aulas { get; set; }
            public DbSet<AlunoModalidade> AlunoModalidades { get; set; }

            public MyDbContext()
            {
                Database.EnsureCreated();
            }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                var server = "localhost";
                var port = "3306";
                var database = "AcademiaLPL";
                var username = "root";
                var password = "kjhg456bta";
                var strCon = $"Server={server};Port={port};Database={database};" +
                    $"Uid={username};Pwd={password}";
                if (!optionsBuilder.IsConfigured)
                {
                    optionsBuilder.UseMySql(strCon, ServerVersion.AutoDetect(strCon));
                }
            }
        }

        [TestMethod]

        public void TestInsertModalidades()
        {
            using (var context = new MyDbContext())
            {

                var modalidade = new Modalidade
                {
                    Nome = "Muay Thai",
                    Descricao = "arte das 8 armas",
                    Precomensal = 90.00
                };
                context.Modalidades.Add(modalidade);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListModalidades()
        {
            using (var context = new MyDbContext())
            {
                foreach (var modalidade in context.Modalidades)
                {
                    Console.WriteLine(JsonSerializer.Serialize(modalidade));
                }
            }
        }

        [TestMethod]
        public void TestInsertProfessors()
        {
            using (var context = new MyDbContext())
            {
                var professor = new Professor
                {
                    Nome = "Lucas Paiva",
                    Telefone = "(18)99689-8374",
                    Email = "lucasbtakjilima@gmail.com",
                    Especialidade = "Professor de Muay Thai"
                };
                context.Professors.Add(professor);

                professor = new Professor
                {
                    Nome = "Wilson",
                    Telefone = "(18)4002-8922",
                    Email = "wilsonkarate@gmail.com",
                    Especialidade = "Professor de karate"
                };
                context.Professors.Add(professor);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListProfessors()
        {
            using (var context = new MyDbContext())
            {
                foreach (var professor in context.Professors)
                {
                    Console.WriteLine(JsonSerializer.Serialize(professor));
                }
            }
        }

        [TestMethod]
        public void TestInsertAlunos()
        {
            using (var context = new MyDbContext())
            {
                var aluno = new Aluno
                {
                    Nome = "Rafael",
                    DataNascimento = DateTime.Parse("19/03/2002"),
                    Telefone = "(18) 8951-1235",
                    Email = "tropadeelite@gmail.com",
                    DataMatricula = DateTime.Parse("09/02/2024"),
                };
                context.Alunos.Add(aluno);

                aluno = new Aluno
                {
                    Nome = "Neleomarlone algusto cassoti",
                    DataNascimento = DateTime.Parse("18/08/2002"),
                    Telefone = "(18) 0007-1235",
                    Email = "cassoti@gmail.com",
                    DataMatricula = DateTime.Parse("09/03/2024"),
                };
                context.Alunos.Add(aluno);
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListAlunos()
        {
            using (var context = new MyDbContext())
            {
                foreach (var aluno in context.Alunos)
                {
                    Console.WriteLine(JsonSerializer.Serialize(aluno));
                }
            }
        }

        [TestMethod]
        public void TestInsertAula()
        {
            using (var context = new MyDbContext())
            {

                var modalidade = context.Modalidades.FirstOrDefault(c => c.Id == 1);
                var professor = context.Professors.FirstOrDefault(c => c.Id == 1);
                var aula = new Aula
                {
                    DiaSemana = "seguna, quarta, sexta",
                    HorarioInicio = DateTime.Parse("19:30"),
                    HorarioFim = DateTime.Parse("20:30")
                };
                context.Aulas.Add(aula);

                modalidade = context.Modalidades.FirstOrDefault(c => c.Id == 1);
                professor = context.Professors.FirstOrDefault(c => c.Id == 1);
                aula = new Aula
                {
                    DiaSemana = "seguna, quarta, sexta",
                    HorarioInicio = DateTime.Parse("9:00"),
                    HorarioFim = DateTime.Parse("9:00")
                };
                context.Aulas.Add(aula);

                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListAulas()
        {
            using (var context = new MyDbContext())
            {
                foreach (var aula in context.Aulas)
                {
                    Console.WriteLine(JsonSerializer.Serialize(aula));
                }
            }
        }

        [TestMethod]
        public void TestInsertAlunoModalidade()
        {
            using (var context = new MyDbContext())
            {

                var aluno = context.Alunos.FirstOrDefault(c => c.Id == 1);
                var modalidade = context.Modalidades.FirstOrDefault(c => c.Id == 1);
                var alunomodalide = new AlunoModalidade
                {
                    DataInicio = DateTime.Parse("10/05/2024")                   
                };
                context.AlunoModalidades.Add(alunomodalide);            
                context.SaveChanges();
            }
        }

        [TestMethod]
        public void TestListAlunoModalidades()
        {
            using (var context = new MyDbContext())
            {
                foreach (var alunomodalidade in context.AlunoModalidades)
                {
                    Console.WriteLine(JsonSerializer.Serialize(alunomodalidade));
                }
            }
        }


    }
}

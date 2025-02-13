using AcademiaLPL.Cadastros;
using AcademiaLPL.Domain.Base;
using AcademiaLPL.Domain.Entities;
using AcademiaLPL.Models;
using AcademiaLPL.Repository.Context;
using AcademiaLPL.Repository.Repository;
using AcademiaLPL.Service.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;

namespace AcademiaLPL.Infra
{
    public static class ConfigureDI
    {
        public static ServiceCollection? Services;
        public static IServiceProvider? ServicesProvider;

        public static void ConfigureServices()
        {
            Services = new ServiceCollection();
            #region Banco de dados
            // Configura Banco na Injeção de dependencia
            var strCon = File.ReadAllText("C:/Users/Usuario/source/repos/ProjetoFinalMRL/AcademiaLPL/AcademiaLPL//Config//ConfigBanco.txt");
            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                .EnableSensitiveDataLogging();
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure();
                });
            });
            #endregion

            #region Repositórios
            Services.AddScoped<IBaseRepository<Modalidade>, BaseRepository<Modalidade>>();
            Services.AddScoped<IBaseRepository<Professor>, BaseRepository<Professor>>();
            Services.AddScoped<IBaseRepository<Aluno>, BaseRepository<Aluno>>();
            Services.AddScoped<IBaseRepository<Aula>, BaseRepository<Aula>>();
            Services.AddScoped<IBaseRepository<AlunoModalidade>, BaseRepository<AlunoModalidade>>();
            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Modalidade>, BaseService<Modalidade>>();
            Services.AddScoped<IBaseService<Professor>, BaseService<Professor>>();
            Services.AddScoped<IBaseService<Aluno>, BaseService<Aluno>>();
            Services.AddScoped<IBaseService<Aula>, BaseService<Aula>>();
            Services.AddScoped<IBaseService<AlunoModalidade>, BaseService<AlunoModalidade>>();
            #endregion

            #region Formulários
            // Formulários
            //Services.AddTransient<Login, Login>();
            Services.AddTransient<CadastroModalidade, CadastroModalidade>();
            Services.AddTransient<CadastroProfessor, CadastroProfessor>();
            Services.AddTransient<CadastroAluno, CadastroAluno>();
            Services.AddTransient<CadastroAula, CadastroAula>();
            Services.AddTransient<CadastroAlunoModalidade, CadastroAlunoModalidade>();
            #endregion

            #region Mappings

            // Mappings
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Aluno, AlunoModel>();

                config.CreateMap<Modalidade, ModalidadeModel>();

                config.CreateMap<Professor, ProfessorModel>();

                config.CreateMap<Aula, AulaModel>()
                    .ForMember(d => d.Nome, d => d.MapFrom(x => x.Modalidade!.Nome))
                    .ForMember(d => d.Id, d => d.MapFrom(x => x.Modalidade!.Id))
                    .ForMember(d => d.Nome, d => d.MapFrom(x => x.Professor!.Nome))
                    .ForMember(d => d.Id, d => d.MapFrom(x => x.Professor!.Id));

                config.CreateMap<AlunoModalidade, AlunoModalidadeModel>()
                    .ForMember(d => d.Id, d => d.MapFrom(x => x.Aluno!.Id))
                    .ForMember(d => d.Id, d => d.MapFrom(x => x.Modalidade!.Id));
            }).CreateMapper());

            #endregion
            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}


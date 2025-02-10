/*using AcademiaLPL.Cadastros;
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
}*/

/*using AcademiaLPL.Cadastros;
using AcademiaLPL.Domain.Base;
using AcademiaLPL.Domain.Entities;
using AcademiaLPL.Models;
using AcademiaLPL.Repository.Context;
using AcademiaLPL.Repository.Repository;
using AcademiaLPL.Service.Services;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;

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
            // Obtendo caminho do arquivo de configuração de forma segura
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Config", "ConfigBanco.txt");

            if (!File.Exists(configPath))
            {
                throw new FileNotFoundException("Arquivo de configuração do banco não encontrado!", configPath);
            }

            var strCon = File.ReadAllText(configPath);

            Services.AddDbContext<MySqlContext>(options =>
            {
                options.LogTo(Console.WriteLine)
                       .EnableSensitiveDataLogging()
                       .UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
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
            Services.AddTransient<CadastroModalidade>();
            Services.AddTransient<CadastroProfessor>();
            Services.AddTransient<CadastroAluno>();
            Services.AddTransient<CadastroAula>();
            Services.AddTransient<CadastroAlunoModalidade>();
            #endregion

            #region Mappings
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Aluno, AlunoModel>();
                config.CreateMap<Modalidade, ModalidadeModel>();
                config.CreateMap<Professor, ProfessorModel>();

                config.CreateMap<Aula, AulaModel>()
                    .ForMember(d => d.Nome, opt => opt.MapFrom(src => src.Modalidade != null ? src.Modalidade.Nome : string.Empty))
                    .ForMember(d => d.Id, opt => opt.MapFrom(src => src.Modalidade != null ? src.Modalidade.Id : 0));

                config.CreateMap<Aula, AulaModel>()
                    .ForMember(d => d.Nome, opt => opt.MapFrom(src => src.Professor != null ? src.Professor.Nome : string.Empty))
                    .ForMember(d => d.Id, opt => opt.MapFrom(src => src.Professor != null ? src.Professor.Id : 0));

                config.CreateMap<AlunoModalidade, AlunoModalidadeModel>()
                    .ForMember(d => d.Id, opt => opt.MapFrom(src => src.Aluno != null ? src.Aluno.Id : 0))
                    .ForMember(d => d.Id, opt => opt.MapFrom(src => src.Modalidade != null ? src.Modalidade.Id : 0));
            }).CreateMapper());
            #endregion

            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}

*/

using AcademiaLPL.Domain.Base;
using AcademiaLPL.Domain.Entities;
using AcademiaLPL.Models;
using AcademiaLPL.Repository.Context;
using AcademiaLPL.Repository.Repository;
using AcademiaLPL.Service.Services;
using AutoMapper;
using AcademiaLPL.Cadastros;
using AcademiaLPL.Models;
//using AcademiaLPL.Outros;
using AcademiaLPL.Domain.Base;
using AcademiaLPL.Domain.Entities;
using AcademiaLPL.Repository.Context;
using AcademiaLPL.Repository.Repository;
using AcademiaLPL.Service.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.Logging;

namespace IFSPStore.App.Infra
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
            var strCon = File.ReadAllText("Config/ConfigBanco.txt");
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
            /*Services.AddScoped<IBaseRepository<Cidade>, BaseRepository<Cidade>>();
            Services.AddScoped<IBaseRepository<Cliente>, BaseRepository<Cliente>>();
            Services.AddScoped<IBaseRepository<Grupo>, BaseRepository<Grupo>>();
            Services.AddScoped<IBaseRepository<Produto>, BaseRepository<Produto>>();
            Services.AddScoped<IBaseRepository<Venda>, BaseRepository<Venda>>();
            Services.AddScoped<IBaseRepository<VendaItem>, BaseRepository<VendaItem>>();*/
            #endregion

            #region Serviços
            Services.AddScoped<IBaseService<Modalidade>, BaseService<Modalidade>>();
            /*Services.AddScoped<IBaseService<Cidade>, BaseService<Cidade>>();
            Services.AddScoped<IBaseService<Cliente>, BaseService<Cliente>>();
            Services.AddScoped<IBaseService<Grupo>, BaseService<Grupo>>();
            Services.AddScoped<IBaseService<Produto>, BaseService<Produto>>();
            Services.AddScoped<IBaseService<Venda>, BaseService<Venda>>();
            Services.AddScoped<IBaseService<VendaItem>, BaseService<VendaItem>>();*/
            #endregion

            #region Formulários
            // Formulários
            Services.AddTransient<Modalidade, Modalidade>();
           /* Services.AddTransient<CadastroUsuario, CadastroUsuario>();
            Services.AddTransient<CadastroGrupo, CadastroGrupo>();
            Services.AddTransient<CadastroProduto, CadastroProduto>();
            Services.AddTransient<CadastroCidade, CadastroCidade>();
            Services.AddTransient<CadastroCliente, CadastroCliente>();
            Services.AddTransient<CadastroVenda, CadastroVenda>();*/
            #endregion

            #region Mappings
            // Mappings
            Services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Modalidade, ModalidadeModel>();

                //config.CreateMap<Cidade, CidadeModel>()
                   // .ForMember(d => d.NomeEstado, d => d.MapFrom(x => $"{x.Nome}/{x.Estado}"));

                ///config.CreateMap<Cliente, ClienteModel>()
                    //.ForMember(d => d.Cidade, d => d.MapFrom(x => $"{x.Cidade!.Nome}/{x.Cidade!.Estado}"))
                    //.ForMember(d => d.IdCidade, d => d.MapFrom(x => x.Cidade!.Id));

                //config.CreateMap<Grupo, GrupoModel>();
                //config.CreateMap<Produto, ProdutoModel>()
                    //.ForMember(d => d.Grupo, d => d.MapFrom(x => x.Grupo!.Nome))
                    //.ForMember(d => d.IdGrupo, d => d.MapFrom(x => x.Grupo!.Id));
                //config.CreateMap<Venda, VendaModel>()
                    //.ForMember(d => d.IdCliente, d => d.MapFrom(x => x.Cliente!.Id))
                    //.ForMember(d => d.Cliente, d => d.MapFrom(x => x.Cliente!.Nome))
                    //.ForMember(d => d.IdUsuario, d => d.MapFrom(x => x.Usuario!.Id))
                    //.ForMember(d => d.Usuario, d => d.MapFrom(x => x.Usuario!.Nome));

                //config.CreateMap<VendaItem, VendaItemModel>()
                    //.ForMember(d => d.IdProduto, d => d.MapFrom(x => x.Produto!.Id))
                    //.ForMember(d => d.Produto, d => d.MapFrom(x => x.Produto!.Nome));

            }).CreateMapper());

            #endregion
            ServicesProvider = Services.BuildServiceProvider();
        }
    }
}

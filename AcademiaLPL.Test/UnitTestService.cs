using AcademiaLPL.Domain.Base;
using AcademiaLPL.Domain.Entities;
using AcademiaLPL.Repository.Context;
using AcademiaLPL.Repository.Repository;
using AcademiaLPL.Service.Services;
using AcademiaLPL.Service.Validators;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text.Json;

namespace AcademiaLPL.Test
{
    [TestClass]
    public class UnitTestService
    {
        private ServiceCollection? services;

        public ServiceProvider ConfigureServices()
        {
            services = new ServiceCollection();
            services.AddDbContext<MySqlContext>(options =>
            {
                var server = "localhost";
                var port = "3306";
                var database = "AcademiaLPL";
                var username = "root";
                var password = "kjhg456bta";
                var strCon = $"Server={server};Port={port};Database={database};" +
                            $"Uid={username};Pwd={password}";
                options.UseMySql(strCon, ServerVersion.AutoDetect(strCon), opt =>
                {
                    opt.CommandTimeout(180);
                    opt.EnableRetryOnFailure(5);
                });
            });
            //configuração para usuario login
            services.AddScoped<IBaseRepository<Modalidade>, BaseRepository<Modalidade>>();
            services.AddScoped<IBaseService<Modalidade>, BaseService<Modalidade>>();
            services.AddSingleton(new MapperConfiguration(config =>
            {
                config.CreateMap<Modalidade, Modalidade>();
            }).CreateMapper());
            return services.BuildServiceProvider();
        }

        [TestMethod]
        public void TestInsertModalidade()
        {
            var sp = ConfigureServices();
            var ModalidadeService = sp.GetService<IBaseService<Modalidade>>();
            var modalidade = new Modalidade
            {
                /*Nome = "muay thai",
                Login = "mvs",
                Email = "murilo@gmail.com",
                Senha = "123Rt@#jdjfhfh!",
                DataCadastro = DateTime.Now*/
                Nome = "muay thai",
                Descricao = "top das galaxias",
                Precomensal = 90.00
            };

            /*var result = usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            Console.Write(JsonSerializer.Serialize(result));*/
            var result = ModalidadeService.Add<Modalidade, Modalidade, ModalidadeValidator>(modalidade);
            Console.Write(JsonSerializer.Serialize(result));
        }

        [TestMethod]
        public void TestSelectModalidade()
        {
            /*var sp = ConfigureServices();
            var usuarioService = sp.GetService<IBaseService<Usuario>>();

            var result = usuarioService.Get<Usuario>();
            Console.Write(JsonSerializer.Serialize(result));*/
            var sp = ConfigureServices();
            var ModalidadeService = sp.GetService<IBaseService<Modalidade>>();

            var result = ModalidadeService.Get<Modalidade>();
            Console.Write(JsonSerializer.Serialize(result));
        }
    }
}

using Application.Interface;
using Application.Service;
using Domain.Interfaces.IRepositories;
using Domain.Interfaces.IServices;
using Domain.Services;
using Infrastructure.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CrossCutting
{
    public class DependencyInjection
    {
        public static void DependencyServices(IServiceCollection services)
        {
            //// AppService
            services.AddTransient<ICarroAppService, CarroAppService>();
            services.AddTransient<IMarcaAppService, MarcaAppService>();
            services.AddTransient<IUsuarioAppService, UsuarioAppService>();

            //// Service
            services.AddTransient<ICarroService, CarroService>();
            services.AddTransient<IMarcaService, MarcaService>();
            services.AddTransient<IUsuarioService, UsuarioService>();

            //// Repository
            services.AddTransient<ICarroRepository, CarroRepository>();
            services.AddTransient<IMarcaRepository, MarcaRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
        }
    }
}

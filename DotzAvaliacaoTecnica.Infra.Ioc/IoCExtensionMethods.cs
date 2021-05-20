using DotzAvaliacaoTecnica.Application.ApplicationServices;
using DotzAvaliacaoTecnica.Application.Interfaces;
using DotzAvaliacaoTecnica.Domain.Interfaces.Infra.Repositories;
using DotzAvaliacaoTecnica.Domain.Interfaces.Services;
using DotzAvaliacaoTecnica.Domain.Services;
using DotzAvaliacaoTecnica.Infra.Repository.Repositories;
using DotzAvaliacaoTecnica.Infra.Repository.UnitOfWork;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DotzAvaliacaoTecnica.Infra.Ioc
{
    public static class IocExtensionMethods
	{
		public static void AddApplicationServices(this IServiceCollection services)
		{
			services.AddTransient<IUserApplicationService, UserApplicationService>();
		}

		

		public static void AddConfiguration(this IServiceCollection services)
		{
			services.AddTransient<IConfiguration>(x =>
			{
				// Get the configuration from the app settings
				return new ConfigurationBuilder()
					.SetBasePath(AppContext.BaseDirectory)
					.AddJsonFile($"appsettings.json", optional: true)
					.Build();
			});
		}

		public static void AddDomainServices(this IServiceCollection services)
		{
			services.AddTransient<IUserService, UserServices>();
		}

		

		

		public static void AddRepositories(this IServiceCollection services)
		{
			services.AddTransient<IUserRepository, UserRepository>();
		}

		public static void AddUnitOfWork(this IServiceCollection services)
		{
			services.AddScoped<IUnitOfWork, UnitOfWork>();
		}

		
	}
}

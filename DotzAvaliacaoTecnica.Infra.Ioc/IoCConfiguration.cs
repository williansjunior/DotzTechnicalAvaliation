using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DotzAvaliacaoTecnica.Infra.Ioc
{
    public class IoCConfiguration
    {
		public static void Configure(IServiceCollection services)
		{
			services.AddApplicationServices();
			services.AddConfiguration();
			services.AddDomainServices();
			services.AddRepositories();
			services.AddUnitOfWork();
		}
	}
}

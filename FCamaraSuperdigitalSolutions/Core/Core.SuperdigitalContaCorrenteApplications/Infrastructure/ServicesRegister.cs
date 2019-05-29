using Core.SuperdigitalContaCorrenteApplications.Services;
using Core.SuperdigitalContaCorrenteApplications.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Core.SuperdigitalContaCorrenteApplications.Infrastructure
{
    public static class ServicesRegister
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddTransient<IContaCorrenteService, ContaCorrenteService>();
            services.AddTransient<ITransferenciaService, TransferenciaService>();
        }
    }
}

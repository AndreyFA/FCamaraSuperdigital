using Core.SuperdigitalContaCorrenteModels.Interfaces.Repositories;
using Core.SuperdigitalContaCorrenteRepositories.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Core.SuperdigitalContaCorrenteApplications.Infrastructure
{
    public static class RepositoriesRegister
    {
        public static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddTransient<IContaCorrenteRepository, ContaCorrenteRepository>();
            services.AddTransient<ILancamentoRepository, LancamentoRepository>();
        }
    }
}

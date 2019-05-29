using Core.SuperdigitalContaCorrenteModels.Entities;
using Core.SuperdigitalContaCorrenteModels.Interfaces.Repositories;

namespace Core.SuperdigitalContaCorrenteRepositories.Repositories
{
    public class LancamentoRepository : BaseRepository<Lancamento>, ILancamentoRepository
    {
        public LancamentoRepository(AppContexto appContexto) : base(appContexto)
        {
        }
    }
}

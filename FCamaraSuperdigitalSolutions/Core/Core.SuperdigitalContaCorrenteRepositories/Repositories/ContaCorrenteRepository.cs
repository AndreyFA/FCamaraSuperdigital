using System.Linq;
using Core.SuperdigitalContaCorrenteModels.Entities;
using Core.SuperdigitalContaCorrenteModels.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Core.SuperdigitalContaCorrenteRepositories.Repositories
{
    public class ContaCorrenteRepository : BaseRepository<ContaCorrente>, IContaCorrenteRepository
    {
        public ContaCorrenteRepository(AppContexto appContexto) : base(appContexto)
        {
        }

        public ContaCorrente BuscarContaCorrentePorAgenciaEConta(int numeroAgencia, int numeroConta)
        {
            return Query()
                .Include(c => c.Lancamentos)
                .FirstOrDefault(c => Equals(c.NumeroConta, numeroConta)
                                            && Equals(c.NumeroAgencia, numeroAgencia));
        }
    }
}

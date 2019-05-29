using Core.SuperdigitalContaCorrenteModels.Entities;

namespace Core.SuperdigitalContaCorrenteModels.Interfaces.Repositories
{
    public interface IContaCorrenteRepository : IBaseRepository<ContaCorrente>
    {
        ContaCorrente BuscarContaCorrentePorAgenciaEConta(int numeroAgencia, int numeroConta);
    }
}

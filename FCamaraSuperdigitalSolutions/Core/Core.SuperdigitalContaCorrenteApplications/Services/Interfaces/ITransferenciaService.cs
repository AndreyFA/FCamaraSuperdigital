using Core.SuperdigitalContaCorrenteApplications.ViewModels;

namespace Core.SuperdigitalContaCorrenteApplications.Services.Interfaces
{
    public interface ITransferenciaService
    {
        void RealizarTransferenciaEntreContas(ContaCorrenteViewModel contaOrigem, ContaCorrenteViewModel contaDestino, decimal valorTransferencia);
    }
}

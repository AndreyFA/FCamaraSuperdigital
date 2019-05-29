using Core.SuperdigitalContaCorrenteApplications.ViewModels;
using System.Collections.Generic;

namespace Core.SuperdigitalContaCorrenteApplications.Services.Interfaces
{
    public interface IContaCorrenteService
    {
        void CriarNovaContaCorrente(ContaCorrenteViewModel contaCorrente);

        decimal ConsultarSaldoContaCorrente(int numeroAgencia, int numeroConta);

        IEnumerable<LancamentoViewModel> ConsultarLancamentos(ConsultaLancamentoCCViewModel consultaLancamentoCCViewModel);
    }
}

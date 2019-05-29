using Core.SuperdigitalContaCorrenteApplications.ViewModels;
using Core.SuperdigitalContaCorrenteModels.Entities;

namespace Core.SuperdigitalContaCorrenteApplications.Adapters
{
    public static class ContaCorrenteAdapter
    {
        public static ContaCorrente ToEntity(this ContaCorrenteViewModel viewModel)
        {
            ContaCorrente contaCorrente = new ContaCorrente
            {
                NumeroConta = viewModel.NumeroConta,
                NumeroAgencia = viewModel.NumeroAgencia
            };

            contaCorrente.RealizarCreditoEmConta(viewModel.Valor);

            return contaCorrente;
        }
    }
}

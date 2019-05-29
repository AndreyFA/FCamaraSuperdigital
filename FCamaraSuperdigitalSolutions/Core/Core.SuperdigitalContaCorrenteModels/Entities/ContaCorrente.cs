namespace Core.SuperdigitalContaCorrenteModels.Entities
{
    public class ContaCorrente : Conta
    {
        public void RealizarTransferenciaPara(Conta conta, decimal valorTransferencia)
        {
            this.RealizarDebitoEmConta(valorTransferencia);
            conta.RealizarCreditoEmConta(valorTransferencia);
        }

        protected override void AplicarEncargosSobreTransferencia(decimal valorTransferencia)
        {
          
        }
    }
}

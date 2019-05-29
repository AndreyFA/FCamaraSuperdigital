using System;
using System.Collections.Generic;
using Core.SuperdigitalContaCorrenteModels.Enums;

namespace Core.SuperdigitalContaCorrenteModels.Entities
{
    public abstract class Conta
    {
        public int Id { get; set; }
        public int NumeroConta { get; set; }
        public int NumeroAgencia { get; set; }
        public decimal Saldo { get; set; }
        public IList<Lancamento> Lancamentos { get; set; } = new List<Lancamento>();

        public virtual void RealizarDebitoEmConta(decimal valor)
        {
            if (valor <= 0)
                throw new Exception("O valor fornecido é inválido!");

            if (Saldo < valor)
                throw new Exception("Saldo insuficiente!");

            Saldo -= valor;
            Lancamentos.Add(new Lancamento(DateTime.Now, this, TipoLancamento.DEBITO_EM_CONTA, valor));
        }

        public virtual void RealizarCreditoEmConta(decimal valor)
        {
            if (valor <= 0)
                throw new Exception("O valor fornecido é inválido!");

            Saldo += valor;
            Lancamentos.Add(new Lancamento(DateTime.Now, this, TipoLancamento.CREDITO_EM_CONTA, valor));
        }

        protected abstract void AplicarEncargosSobreTransferencia(decimal valorTransferencia);
    }
}

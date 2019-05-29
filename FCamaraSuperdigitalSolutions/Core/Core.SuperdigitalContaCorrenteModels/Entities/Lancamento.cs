using System;
using Core.SuperdigitalContaCorrenteModels.Enums;

namespace Core.SuperdigitalContaCorrenteModels.Entities
{
    public class Lancamento
    {
        public long Id { get; set; }
        public DateTime DataOperacao { get; protected set; } = DateTime.Now;
        public Conta ContaOrigem { get; protected set; }
        public TipoLancamento Tipo { get; protected set; }
        public decimal ValorTransferencia { get; set; }

        public Lancamento()
        {

        }

        public Lancamento(DateTime dataOperacao, Conta contaOrigem, TipoLancamento tipo, decimal valorTransferencia)
        {
            if (Equals(contaOrigem, null))
                throw new Exception("Informe uma conta válida!");

            DataOperacao = dataOperacao;
            ContaOrigem = contaOrigem;
            Tipo = tipo;
            ValorTransferencia = valorTransferencia;
        }


    }
}

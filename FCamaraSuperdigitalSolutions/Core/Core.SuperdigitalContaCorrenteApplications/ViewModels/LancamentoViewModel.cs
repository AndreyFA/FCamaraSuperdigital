using System;
using System.Collections.Generic;
using System.Text;

namespace Core.SuperdigitalContaCorrenteApplications.ViewModels
{
    public class LancamentoViewModel
    {
        public DateTime DataOperacao { get; set; } = DateTime.Now;
        public string Tipo { get; set; }
        public decimal ValorTransferencia { get; set; }

        public LancamentoViewModel(DateTime data, string tipo, decimal valor)
        {
            DataOperacao = data;
            Tipo = tipo;
            ValorTransferencia = valor;
        }
    }
}

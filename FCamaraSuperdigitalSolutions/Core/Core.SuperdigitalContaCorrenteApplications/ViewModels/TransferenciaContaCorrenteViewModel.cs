using System.ComponentModel.DataAnnotations;

namespace Core.SuperdigitalContaCorrenteApplications.ViewModels
{
    /// <summary>
    /// Representa uma transferência entre duas contas correntes.
    /// </summary>
    public class TransferenciaContaCorrenteViewModel
    {
        /// <summary>
        /// Conta corrente origem da transferência.
        /// </summary>
        [Required]
        public ContaCorrenteViewModel ContaCorrenteOrigem { get; set; }

        /// <summary>
        /// Conta corrente destino.
        /// </summary>
        [Required]
        public ContaCorrenteViewModel ContaCorrenteDestino { get; set; }

        /// <summary>
        /// Valor da transferência.
        /// </summary>
        [Required]
        public decimal ValorTransferencia { get; set; }

    }
}

using System.ComponentModel.DataAnnotations;

namespace Core.SuperdigitalContaCorrenteApplications.ViewModels
{
    /// <summary>
    /// Representa uma conta corrente no sistema.
    /// </summary>
    public class ContaCorrenteViewModel
    {
        /// <summary>
        /// Número da conta. Utilizar apenas números
        /// </summary>
        [Required]
        public int NumeroConta { get; set; }

        /// <summary>
        /// Número da agência, representado apenas por números.
        /// </summary>
        [Required]
        public int NumeroAgencia { get; set; }

        /// <summary>
        /// Saldo da conta corrente.
        /// </summary>
        public decimal Valor { get; set; } = 0;
    }
}

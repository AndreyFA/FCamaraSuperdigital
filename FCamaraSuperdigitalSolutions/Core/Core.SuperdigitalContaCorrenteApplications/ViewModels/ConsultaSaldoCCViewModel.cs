using System.ComponentModel.DataAnnotations;

namespace Core.SuperdigitalContaCorrenteApplications.ViewModels
{
    /// <summary>
    /// Entidade que representa a consulta do Saldo.
    /// </summary>
    public class ConsultaSaldoCCViewModel
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
    }
}

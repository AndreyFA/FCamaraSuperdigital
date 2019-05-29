using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Core.SuperdigitalContaCorrenteApplications.ViewModels
{
    /// <summary>
    /// Entidade que representa a consulta dos lançamentos de uma conta.
    /// </summary>
    public class ConsultaLancamentoCCViewModel
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

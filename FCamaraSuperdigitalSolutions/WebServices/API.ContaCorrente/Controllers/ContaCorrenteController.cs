using System;
using Core.SuperdigitalContaCorrenteApplications.Services.Interfaces;
using Core.SuperdigitalContaCorrenteApplications.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace API.ContaCorrente.Controllers
{
    /// <summary>
    /// API responsável por fazer gestão das contas correntes.
    /// </summary>
    [Route("api/ContaCorrente")]
    [Produces("application/json")]
    [ApiController]
    public class ContaCorrenteController : ControllerBase
    {
        private readonly ITransferenciaService _transferenciaService;
        private readonly IContaCorrenteService _contaCorrenteService;

        public ContaCorrenteController(
            ITransferenciaService transferenciaService,
            IContaCorrenteService contaCorrenteService)
        {
            _transferenciaService = transferenciaService;
            _contaCorrenteService = contaCorrenteService;
        }

        /// <summary>
        /// Responsável pelo cadastro de uma nova conta corrente.
        /// </summary>
        /// <param name="contaCorrente">Representa uma conta corrente.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("CadastrarNovaContaCorrente")]
        public IActionResult CadastrarNovaContaCorrente([FromBody] ContaCorrenteViewModel contaCorrente)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                _contaCorrenteService.CriarNovaContaCorrente(contaCorrente);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Responsável por realizar a consulta do Saldo em conta corrente.
        /// </summary>
        /// <param name="consultaSaldo">Representa o dados para consulta do saldo.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("ConsultarSaldoContaCorrente")]
        public IActionResult ConsultarSaldoContaCorrente([FromBody] ConsultaSaldoCCViewModel consultaSaldo)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                decimal saldo = _contaCorrenteService.ConsultarSaldoContaCorrente(
                    consultaSaldo.NumeroAgencia,
                    consultaSaldo.NumeroConta);

                return Ok($"R$ {saldo}");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Responsável por realizar a transfêrencia entre duas contas correntes.
        /// </summary>
        /// <param name="transferenciaContaCorrenteView">Representa uma transferência entre duas contas correntes.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("RealizarTransferencia")]
        public IActionResult RealizarTransferencia([FromBody] TransferenciaContaCorrenteViewModel transferenciaContaCorrenteView)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                _transferenciaService.RealizarTransferenciaEntreContas(
                    transferenciaContaCorrenteView.ContaCorrenteOrigem,
                    transferenciaContaCorrenteView.ContaCorrenteDestino,
                    transferenciaContaCorrenteView.ValorTransferencia);

                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        /// <summary>
        /// Responsável por consultar os lançamentos na conta corrente.
        /// </summary>
        /// <param name="consultaLancamentoCCViewModel">Entidade que representa a consulta dos lançamentos de uma conta corrente.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("ConsultarLancamentos")]
        public IActionResult ConsultarLancamentos([FromBody] ConsultaLancamentoCCViewModel consultaLancamentoCCViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var lancamentos = _contaCorrenteService.ConsultarLancamentos(consultaLancamentoCCViewModel);

                return Ok(lancamentos);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
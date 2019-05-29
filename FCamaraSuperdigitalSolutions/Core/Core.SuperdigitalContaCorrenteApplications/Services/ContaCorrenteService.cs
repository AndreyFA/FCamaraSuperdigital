using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Core.SuperdigitalContaCorrenteApplications.Adapters;
using Core.SuperdigitalContaCorrenteApplications.Services.Interfaces;
using Core.SuperdigitalContaCorrenteApplications.ViewModels;
using Core.SuperdigitalContaCorrenteModels.Entities;
using Core.SuperdigitalContaCorrenteModels.Interfaces.Repositories;

namespace Core.SuperdigitalContaCorrenteApplications.Services
{
    public class ContaCorrenteService : IContaCorrenteService
    {
        private readonly IContaCorrenteRepository _contaCorrenteRepository;

        public ContaCorrenteService(IContaCorrenteRepository contaCorrenteRepository)
        {
            _contaCorrenteRepository = contaCorrenteRepository;
        }

        public decimal ConsultarSaldoContaCorrente(int numeroAgencia, int numeroConta)
        {
            ContaCorrente contaCorrente = _contaCorrenteRepository.BuscarContaCorrentePorAgenciaEConta(numeroAgencia, numeroConta);

            if (Equals(contaCorrente, null))
                throw new Exception($"Conta: Nº {numeroConta} - Agência: {numeroAgencia} não localizada!");

            return contaCorrente.Saldo;
        }

        public void CriarNovaContaCorrente(ContaCorrenteViewModel contaCorrente)
        {
            _contaCorrenteRepository.Salvar(contaCorrente.ToEntity());
        }

        public IEnumerable<LancamentoViewModel> ConsultarLancamentos(ConsultaLancamentoCCViewModel consultaLancamentoCCViewModel)
        {
            var contaCorrente = _contaCorrenteRepository.BuscarContaCorrentePorAgenciaEConta(
                consultaLancamentoCCViewModel.NumeroAgencia,
                consultaLancamentoCCViewModel.NumeroConta);

            var lancamentos = contaCorrente.Lancamentos.Select(c => new LancamentoViewModel(c.DataOperacao, c.Tipo.ToString(), c.ValorTransferencia));

            return lancamentos;
        }
        
    }
}

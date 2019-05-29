using System;
using Core.SuperdigitalContaCorrenteApplications.Services.Interfaces;
using Core.SuperdigitalContaCorrenteApplications.ViewModels;
using Core.SuperdigitalContaCorrenteModels.Entities;
using Core.SuperdigitalContaCorrenteModels.Interfaces.Repositories;

namespace Core.SuperdigitalContaCorrenteApplications.Services
{
    public class TransferenciaService : ITransferenciaService
    {
        private readonly IContaCorrenteRepository _contaCorrenteRepository;

        public TransferenciaService(IContaCorrenteRepository contaCorrenteRepository)
        {
            _contaCorrenteRepository = contaCorrenteRepository;
        }

        public void RealizarTransferenciaEntreContas(ContaCorrenteViewModel contaOrigem, ContaCorrenteViewModel contaDestino, decimal valorTransferencia)
        {
            ContaCorrente origem = ObterContaCorrentePorNumeroEAgencia(contaOrigem.NumeroConta, contaOrigem.NumeroAgencia);
            ContaCorrente destino = ObterContaCorrentePorNumeroEAgencia(contaDestino.NumeroConta, contaDestino.NumeroAgencia);

            origem.RealizarTransferenciaPara(destino, valorTransferencia);

            _contaCorrenteRepository.Atualizar(origem);
            _contaCorrenteRepository.Atualizar(destino);
        }

        private ContaCorrente ObterContaCorrentePorNumeroEAgencia(int numeroAgencia, int numeroConta)
        {
            ContaCorrente contaCorrente = _contaCorrenteRepository.BuscarContaCorrentePorAgenciaEConta(numeroAgencia, numeroConta);

            if (Equals(contaCorrente, null))
                throw new Exception($"Conta: Nº {numeroConta} - Agência: {numeroAgencia} não localizada!");

            return contaCorrente;
        }
    }
}

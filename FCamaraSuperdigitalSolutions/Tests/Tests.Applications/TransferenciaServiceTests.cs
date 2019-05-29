using Core.SuperdigitalContaCorrenteApplications.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Applications
{
    [TestClass]
    public class TransferenciaServiceTests
    {
        private readonly ITransferenciaService _transferenciaService;
        private readonly IContaCorrenteService _contaCorrenteService;

        public TransferenciaServiceTests(
            ITransferenciaService transferenciaService,
            IContaCorrenteService contaCorrenteService)
        {
            _transferenciaService = transferenciaService;
            _contaCorrenteService = contaCorrenteService;
        }

        [TestMethod]
        public void DeveSerPossivelCriarUmaContaCorrente()
        {

        }
    }
}

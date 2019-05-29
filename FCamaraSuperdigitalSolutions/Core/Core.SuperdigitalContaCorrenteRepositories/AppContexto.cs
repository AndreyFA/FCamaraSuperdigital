using Core.SuperdigitalContaCorrenteModels.Entities;
using Core.SuperdigitalContaCorrenteModels.Interfaces.Repositories;
using Core.SuperdigitalContaCorrenteRepositories.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Core.SuperdigitalContaCorrenteRepositories
{
    public class AppContexto : DbContext
    {
        private IContaCorrenteRepository _contaCorrenteRepository;
        private ILancamentoRepository _lancamentoRepository;

        public DbSet<ContaCorrente> ContasCorrentes { get; set; }
        public DbSet<Lancamento> Lancamentos { get; set; }

        private readonly IConfiguration _configuration;
        public AppContexto(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IContaCorrenteRepository ContaCorrenteRepository
        {
            get
            {
                if (Equals(_contaCorrenteRepository, null))
                    _contaCorrenteRepository = new ContaCorrenteRepository(this);

                return _contaCorrenteRepository;
            }
        }

        public ILancamentoRepository LancamentoRepository
        {
            get
            {
                if (Equals(_lancamentoRepository, null))
                    _lancamentoRepository = new LancamentoRepository(this);

                return _lancamentoRepository;
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseInMemoryDatabase();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

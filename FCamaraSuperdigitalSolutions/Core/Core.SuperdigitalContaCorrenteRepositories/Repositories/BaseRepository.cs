using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Core.SuperdigitalContaCorrenteRepositories.Repositories
{
    public abstract class BaseRepository<T> where T : class
    {
        protected readonly DbSet<T> _repository;
        protected readonly AppContexto _appContexto;

        public IQueryable<T> Query(Expression<Func<T, bool>> predicate)
        {
            return _repository.Where(predicate);
        }

        public IQueryable<T> Query()
        {
            return _repository;
        }

        public BaseRepository(AppContexto appContexto)
        {
            _repository = appContexto.Set<T>();
            _appContexto = appContexto;
        }

        public void Salvar(T entidade)
        {
            _repository.Add(entidade);
            _appContexto.SaveChanges();
        }

        public void Atualizar(T entidade)
        {
            _repository.Update(entidade);
            _appContexto.SaveChanges();
        }

        public void Remover(T entidade)
        {
            _repository.Remove(entidade);
            _appContexto.SaveChanges();
        }
    }
}

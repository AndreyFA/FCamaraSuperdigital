using System;
using System.Linq;
using System.Linq.Expressions;

namespace Core.SuperdigitalContaCorrenteModels.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        IQueryable<T> Query(Expression<Func<T, bool>> predicate);

        IQueryable<T> Query();

        void Salvar(T entidade);

        void Atualizar(T entidade);

        void Remover(T entidade);
    }
}

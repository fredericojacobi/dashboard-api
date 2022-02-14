using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Contracts.Repositories
{
    public interface IRepositoryBase<T>
    {
        Task<IList<T>> ReadAllAsync(params Expression<Func<T, bool>>[] includeExpressions);
        Task<IList<T>> ReadByConditionAsync(Expression<Func<T, bool>> whereExpression,
            params Expression<Func<T, object>>[] includeExpressions);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(Guid id, T entity);
        Task<bool> DeleteAsync(T entity);
    }
}
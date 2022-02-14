using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Contracts.Repositories;
using Entities.Context;
using Microsoft.EntityFrameworkCore;

namespace Repositories
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private DashboardContext _context { get; }

        protected RepositoryBase(DashboardContext context) => _context = context;

        public async Task<IList<T>> ReadAllAsync(params Expression<Func<T, bool>>[] includeExpressions)
        {
            var query = _context.Set<T>();
            if (!includeExpressions.Any()) return await query.AsNoTracking().ToListAsync();
            includeExpressions.ToList().ForEach(x => query.Include(x));
            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<IList<T>> ReadByConditionAsync(Expression<Func<T, bool>> whereExpression, params Expression<Func<T, object>>[] includeExpressions)
        {
            var query = _context.Set<T>().Where(whereExpression);
            if (!includeExpressions.Any()) return await query.AsNoTracking().ToListAsync();
            includeExpressions.ToList().ForEach(x => query.Include(x));
            return await query.AsNoTracking().ToListAsync();
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();
            await _context.Entry(entity).ReloadAsync();
            return entity;
        }

        public async Task<T> UpdateAsync(Guid id, T entity)
        {
            var currentEntity = _context.Set<T>().FindAsync(id);
            _context.Entry(currentEntity.Result).CurrentValues.SetValues(entity);
            await _context.SaveChangesAsync();
            await _context.Entry(entity).ReloadAsync();
            return entity;
        }

        public async Task<bool> DeleteAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
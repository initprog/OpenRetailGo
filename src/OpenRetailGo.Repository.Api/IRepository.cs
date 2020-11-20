using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace OpenRetailGo.Repository.Api
{
    public interface IRepository<TEntity>
    {
        Task<TEntity> GetAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        Task<IEnumerable<TEntity>> FindAsync(Expression<Func<TEntity, bool>> predicate);

        // This method was not in the videos, but I thought it would be useful to add.
        Task<TEntity> SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        Task AddAsync(TEntity entity);
        Task<int> AddRangeAsync(IEnumerable<TEntity> entities);

        Task RemoveAsync(Guid id);
        Task RemoveAsync(TEntity entity);
        Task RemoveRangeAsync(IEnumerable<TEntity> entities);
        
        Task UpdateAsync(TEntity entity);
    }
}

using System.Linq.Expressions;

namespace Clever.Domain.Core.Interfaces.Repositorys;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    Task<TEntity> CreateAsync(TEntity entity);

    Task<TEntity> UpdateAsync(TEntity entity);

    Task DeleteAsync(int id);

    Task<TEntity> GetById(int id);

    Task<TEntity?> GetAsNoTracking(Expression<Func<TEntity, bool>> predicate);

    Task<IEnumerable<TEntity>> GetAllAsync();

    Task<IEnumerable<TEntity>> GetByFilterAsync(Expression<Func<TEntity, bool>> filter);
}
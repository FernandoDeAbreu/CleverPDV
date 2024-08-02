using System.Linq.Expressions;

namespace Clever.Domain.Core.Interfaces.Repositorys;

public interface IRepositoryBase<TEntity> where TEntity : class
{
    Task<TEntity> CreateAsync(TEntity entity);

    Task<TEntity> UpdateAsync(TEntity entity);

    Task DeleteAsync(int id);

    Task<TEntity> GetByIdAsync(int id);

    Task<IEnumerable<TEntity>> GetAllAsync();

    Task<IEnumerable<TEntity>> GetByFilterAsync(Expression<Func<TEntity, bool>> filter);
}
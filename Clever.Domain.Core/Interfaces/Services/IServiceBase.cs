namespace Clever.Domain.Core.Interfaces.Services;

public interface IServiceBase<TEntity> where TEntity : class
{
    Task<TEntity> Create(TEntity entity);

    Task<TEntity> Update(TEntity entity);

    Task Delete(int id);

    Task<IEnumerable<TEntity>> GetAll();

    Task<TEntity> GetById(int id);
}
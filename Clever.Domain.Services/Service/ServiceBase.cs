using Clever.Domain.Core.Interfaces.Repositorys;
using Clever.Domain.Core.Interfaces.Services;

namespace Clever.Domain.Services.Service;

public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
{
    private readonly IRepositoryBase<TEntity> _repositoryBase;

    public ServiceBase(IRepositoryBase<TEntity> repositoryBase)
    {
        _repositoryBase = repositoryBase;
    }

    public Task<TEntity> Create(TEntity entity)
    {
        return _repositoryBase.CreateAsync(entity);
    }

    public Task<TEntity> Update(TEntity entity)
    {
        return _repositoryBase.UpdateAsync(entity);
    }

    public async Task Delete(int id)
    {
        await _repositoryBase.DeleteAsync(id);
    }

    public async Task<IEnumerable<TEntity>> GetAll()
    {
        return await _repositoryBase.GetAllAsync();
    }

    public async Task<TEntity> GetById(int id)
    {
        return await _repositoryBase.GetByIdAsync(id);
    }
}
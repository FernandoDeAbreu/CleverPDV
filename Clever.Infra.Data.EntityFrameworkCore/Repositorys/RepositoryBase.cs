using Clever.Domain.Core.Interfaces.Repositorys;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Clever.Infra.Data.EntityFrameworkCore.Repositorys;

public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
{
    private readonly CleverDbContext _context;

    public RepositoryBase(CleverDbContext context)
    {
        _context = context;
    }

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task DeleteAsync(int id)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id) ?? throw new KeyNotFoundException($"Não encontrado{id}");

        _context.Set<TEntity>().Remove(entity);

        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _context.Set<TEntity>().ToListAsync();
    }

    public async Task<IEnumerable<TEntity>> GetByFilterAsync(Expression<Func<TEntity, bool>> filter)
    {
        return await _context.Set<TEntity>().Where(filter).ToListAsync();
    }

    public async Task<TEntity> GetByIdAsync(int id)
    {
        var entity = await _context.Set<TEntity>().FindAsync(id) ?? throw new KeyNotFoundException($"Não encontrado{id}");

        return entity;
    }
}
using Clever.Domain.Entitys;

namespace Clever.Domain.Core.Interfaces.Services;

public interface ICategoriaService : IServiceBase<Categoria>
{
    Task<Categoria?> GetByIdAsNoTracking(int id);
}
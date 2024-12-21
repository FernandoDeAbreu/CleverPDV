using Clever.Domain.Core.Interfaces.Repositorys;
using Clever.Domain.Core.Interfaces.Services;
using Clever.Domain.Entitys;

namespace Clever.Domain.Services.Service;

public class CategoriaService : ServiceBase<Categoria>, ICategoriaService
{
    private readonly ICategoriaRepository _repository;

    public CategoriaService(ICategoriaRepository CategoriaRepository, ICategoriaRepository repository) : base(CategoriaRepository)
    {
        _repository = repository;
    }

    public Task<Categoria?> GetByIdAsNoTracking(int id)
    {
        return _repository.GetAsNoTracking(c => c.Id == id);
    }
}
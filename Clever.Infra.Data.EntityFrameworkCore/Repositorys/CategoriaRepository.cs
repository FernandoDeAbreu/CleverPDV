using Clever.Domain.Core.Interfaces.Repositorys;
using Clever.Domain.Entitys;

namespace Clever.Infra.Data.EntityFrameworkCore.Repositorys;

public class CategoriaRepository : RepositoryBase<Categoria>, ICategoriaRepository
{
    public CategoriaRepository(CleverDbContext context) : base(context)
    {
    }
}
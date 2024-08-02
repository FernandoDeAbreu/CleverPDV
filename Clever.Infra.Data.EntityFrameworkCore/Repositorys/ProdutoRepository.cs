using Clever.Domain.Core.Interfaces.Repositorys;
using Clever.Domain.Entitys;

namespace Clever.Infra.Data.EntityFrameworkCore.Repositorys;

public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
{
    public ProdutoRepository(CleverDbContext context) : base(context)
    {
    }
}
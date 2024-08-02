using Clever.Domain.Core.Interfaces.Repositorys;
using Clever.Domain.Core.Interfaces.Services;
using Clever.Domain.Entitys;

namespace Clever.Domain.Services.Service;

public class ProdutoService : ServiceBase<Produto>, IProdutoService
{
    public ProdutoService(IProdutoRepository produtoRepository) : base(produtoRepository)
    {
    }
}
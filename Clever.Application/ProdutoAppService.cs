using AutoMapper;
using Clever.Application.Interfaces;
using Clever.Domain.Core.Interfaces.Services;
using Clever.Domain.Entitys;
using Clever.Shared.Dtos;

namespace Clever.Application;

public class ProdutoAppService : AppServiceBase<ProdutoDto, Produto>, IProdutoAppService
{
    public ProdutoAppService(IProdutoService produtoService, IMapper mapper) : base(produtoService, mapper)
    {
    }
}
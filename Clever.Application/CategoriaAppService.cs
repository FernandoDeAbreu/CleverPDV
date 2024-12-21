using AutoMapper;
using Clever.Application.Interfaces;
using Clever.Domain.Core.Interfaces.Services;
using Clever.Domain.Entitys;
using Clever.Shared.Dtos;

namespace Clever.Application;

public class CategoriaAppService : AppServiceBase<CategoriaDto, Categoria>, ICategoriaAppService
{
    private readonly ICategoriaService _categoriaService;

    public CategoriaAppService(ICategoriaService CategoriaService, IMapper mapper, ICategoriaService categoriaService) : base(CategoriaService, mapper)
    {
        _categoriaService = categoriaService;
    }

    public async Task<CategoriaDto> GetAsNoTracking(int Id)
    {
        var entity = await _categoriaService.GetById(Id);
        return _mapper.Map<CategoriaDto>(entity);
    }
}
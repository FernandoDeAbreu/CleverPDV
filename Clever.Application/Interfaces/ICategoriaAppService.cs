using Clever.Shared.Dtos;

namespace Clever.Application.Interfaces;

public interface ICategoriaAppService : IAppServiceBase<CategoriaDto>
{
    Task<CategoriaDto> GetAsNoTracking(int Id);
}
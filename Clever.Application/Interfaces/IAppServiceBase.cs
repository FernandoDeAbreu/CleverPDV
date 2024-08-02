namespace Clever.Application.Interfaces;

public interface IAppServiceBase<Dto>
{
    Task<Dto> Create(Dto model);

    Task<Dto> Update(Dto model);

    Task Delete(int id);

    Task<IEnumerable<Dto>> GetAll();

    Task<Dto> GetById(int id);
}
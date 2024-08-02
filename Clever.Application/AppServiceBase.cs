using AutoMapper;
using Clever.Application.Interfaces;
using Clever.Domain.Core.Interfaces.Services;

namespace Clever.Application;

public class AppServiceBase<Dto, TEntity> : IAppServiceBase<Dto> where TEntity : class
{
    protected readonly IServiceBase<TEntity> _service;
    protected readonly IMapper _mapper;

    public AppServiceBase(IServiceBase<TEntity> service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }

    public async Task<Dto> Create(Dto model)
    {
        var entity = await _service.Create(_mapper.Map<TEntity>(model));
        return _mapper.Map<Dto>(entity);
    }

    public async Task<Dto> Update(Dto model)
    {
        var entity = await _service.Update(_mapper.Map<TEntity>(model));
        return _mapper.Map<Dto>(entity);
    }

    public async Task Delete(int id)
    {
        await _service.Delete(id);
    }

    public async Task<IEnumerable<Dto>> GetAll()
    {
        var entity = await _service.GetAll();
        return _mapper.Map<IEnumerable<Dto>>(entity);
    }

    public async Task<Dto> GetById(int id)
    {
        var entity = await _service.GetById(id);
        return _mapper.Map<Dto>(entity);
    }
}
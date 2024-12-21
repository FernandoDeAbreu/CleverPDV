using AutoMapper;
using Clever.Domain.Entitys;
using Clever.Shared.Dtos;

namespace Clever.Application.AutoMapperProfile;

public class CategoriaProfile : Profile
{
    public CategoriaProfile()
    {
        CreateMap<CategoriaDto, Categoria>().ReverseMap();
    }
}
using AutoMapper;
using Clever.Domain.Entitys;
using Clever.Shared.Dtos;

namespace Clever.Application.AutoMapperProfile;

public class ProdutoProfile : Profile
{
    public ProdutoProfile()
    {
        CreateMap<ProdutoDto, Produto>().ReverseMap();
    }
}
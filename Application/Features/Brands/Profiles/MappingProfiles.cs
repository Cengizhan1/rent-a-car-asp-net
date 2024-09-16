using Application.Features.Brands.Commands.Create;
using Application.Features.Brands.Commands.Delete;
using Application.Features.Brands.Commands.Update;
using Application.Features.Brands.Queries.GetById;
using Application.Features.Brands.Queries.GetList;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistance.Paging;
using Domain.Entities;

namespace Application.Features.Brands.Profiles;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        // Create
        CreateMap<Brand,CreateBrandCommand>().ReverseMap();
        CreateMap<Brand,CreatedBrandResponse>().ReverseMap();
        //Update
        CreateMap<Brand, UpdateBrandCommand>().ReverseMap();
        CreateMap<Brand, UpdatedBrandResponse>().ReverseMap();
        //Delete
        CreateMap<Brand, DeleteBrandCommand>().ReverseMap();
        CreateMap<Brand, DeletedBrandResponse>().ReverseMap();

        CreateMap<Brand, GetListBrandListItemDto>().ReverseMap();
        CreateMap<Brand, GetByIdBrandResponse>().ReverseMap();
        CreateMap<Paginate<Brand>, GetListResponse<GetListBrandListItemDto>>().ReverseMap();
    }
}

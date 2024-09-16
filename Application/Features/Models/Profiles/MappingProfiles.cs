using Application.Features.Models.Queries.GetList;
using Application.Features.Models.Queries.GetListByDynamic;
using AutoMapper;
using Core.Application.Responses;
using Core.Persistance.Paging;
using Domain.Entities;

namespace Application.Features.Models.Profiles;

public class MappingProfiles:Profile
{
    public MappingProfiles()
    {
        // Create
        //CreateMap<Model,CreateModelCommand>().ReverseMap();
        //CreateMap<Brand,CreatedModelResponse>().ReverseMap();
        //Update
        //CreateMap<Brand, UpdateModelCommand>().ReverseMap();
        //CreateMap<Brand, UpdatedModelResponse>().ReverseMap();
        //Delete
        //CreateMap<Brand, DeleteModelCommand>().ReverseMap();
        //CreateMap<Brand, DeletedModelResponse>().ReverseMap();

        CreateMap<Model, GetListModelListItemDto>().ReverseMap();
        CreateMap<Model, GetListByDynamicModelListItemDto>().ReverseMap();
        //CreateMap<Model, GetByIdModelResponse>().ReverseMap();
        CreateMap<Paginate<Model>, GetListResponse<GetListModelListItemDto>>().ReverseMap();
        CreateMap<Paginate<Model>, GetListResponse<GetListByDynamicModelListItemDto>>().ReverseMap();
    }
}

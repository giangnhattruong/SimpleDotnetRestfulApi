using AutoMapper;
using SimpleRestfulApi.Domain.Models;
using SimpleRestfulApi.Domain.Models.Queries;
using SimpleRestfulApi.Extensions;
using SimpleRestfulApi.Resources;

namespace SimpleRestfulApi.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                           opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));

            CreateMap<QueryResult<Product>, QueryResultResource<ProductResource>>();
        }
    }
}

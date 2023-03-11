using AutoMapper;
using SimpleRestfulApi.Domain.Models;
using SimpleRestfulApi.Resources;

namespace SimpleRestfulApi.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveCategoryResource, Category>();
        }
    }
}

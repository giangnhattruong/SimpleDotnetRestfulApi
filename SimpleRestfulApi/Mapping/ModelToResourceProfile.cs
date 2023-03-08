using AutoMapper;
using SimpleRestfulApi.Domain.Models;
using SimpleRestfulApi.Resources;

namespace SimpleRestfulApi.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();
        }
    }
}

using Microsoft.Extensions.Caching.Memory;
using SimpleRestfulApi.Domain.Repositories;

namespace SimpleRestfulApi.Services
{
    public abstract class BaseService
    {
        protected readonly IUnitOfWork _unitOfWork;
        protected readonly IMemoryCache _cache;

        public BaseService(IUnitOfWork unitOfWork, IMemoryCache cache)
        {
            _unitOfWork = unitOfWork;
            _cache = cache;
        }
    }
}

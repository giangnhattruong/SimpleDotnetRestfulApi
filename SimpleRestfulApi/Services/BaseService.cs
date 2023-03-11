using SimpleRestfulApi.Domain.Repositories;

namespace SimpleRestfulApi.Services
{
    public abstract class BaseService
    {
        protected readonly IUnitOfWork _unitOfWork;

        public BaseService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}

using SimpleRestfulApi.Domain.Models;

namespace SimpleRestfulApi.Domain.Repositories
{
    public interface ICategoryRespository
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}

using SimpleRestfulApi.Domain.Models;

namespace SimpleRestfulApi.Domain.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}

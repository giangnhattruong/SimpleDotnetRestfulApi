using SimpleRestfulApi.Domain.Models;

namespace SimpleRestfulApi.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> ListAsync();
    }
}

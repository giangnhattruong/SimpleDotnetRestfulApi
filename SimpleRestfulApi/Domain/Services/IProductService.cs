using SimpleRestfulApi.Domain.Models;

namespace SimpleRestfulApi.Domain.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}

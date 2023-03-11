using SimpleRestfulApi.Domain.Models;

namespace SimpleRestfulApi.Domain.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> ListAsync();
    }
}

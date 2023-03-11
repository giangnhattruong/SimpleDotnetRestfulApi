using SimpleRestfulApi.Domain.Models;
using SimpleRestfulApi.Domain.Models.Queries;
using SimpleRestfulApi.Services.Communication;

namespace SimpleRestfulApi.Domain.Services
{
    public interface IProductService
    {
        Task<QueryResult<Product>> ListAsync(ProductsQuery query);
        Task<ProductResponse> SaveAsync(Product product);
        Task<ProductResponse> UpdateAsync(int id, Product product);
        Task<ProductResponse> DeleteAsync(int id);
    }
}

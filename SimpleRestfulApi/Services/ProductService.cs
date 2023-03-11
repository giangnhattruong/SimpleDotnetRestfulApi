using SimpleRestfulApi.Domain.Models;
using SimpleRestfulApi.Domain.Repositories;
using SimpleRestfulApi.Domain.Services;
using System.Collections;

namespace SimpleRestfulApi.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }
    }
}

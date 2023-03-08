using SimpleRestfulApi.Domain.Models;
using SimpleRestfulApi.Domain.Repositories;
using SimpleRestfulApi.Domain.Services;

namespace SimpleRestfulApi.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRespository _categoryRepository;
        public CategoryService(ICategoryRespository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _categoryRepository.ListAsync();
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleRestfulApi.Domain.Models;
using SimpleRestfulApi.Services;

namespace SimpleRestfulApi.Controllers
{
    [Route("/api/v1.0/[controller]")]
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var categories = await _categoryService.ListAsync();
            return categories;
        }
    }
}

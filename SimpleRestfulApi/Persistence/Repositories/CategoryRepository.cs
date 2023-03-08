using Microsoft.EntityFrameworkCore;
using SimpleRestfulApi.Domain.Models;
using SimpleRestfulApi.Domain.Repositories;
using SimpleRestfulApi.Persistence.Contexts;

namespace SimpleRestfulApi.Persistence.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRespository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SimpleRestfulApi.Domain.Models;
using SimpleRestfulApi.Domain.Repositories;
using SimpleRestfulApi.Persistence.Contexts;

namespace SimpleRestfulApi.Persistence.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {

        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            var builder = _context.Products.Include(p => p.Category);
            return await builder.ToListAsync();
        }
    }
}

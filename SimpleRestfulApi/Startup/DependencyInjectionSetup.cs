using Microsoft.EntityFrameworkCore;
using SimpleRestfulApi.Domain.Repositories;
using SimpleRestfulApi.Domain.Services;
using SimpleRestfulApi.Persistence.Contexts;
using SimpleRestfulApi.Persistence.Repositories;
using SimpleRestfulApi.Services;

namespace SimpleRestfulApi.Startup
{
    public static class DependencyInjectionSetup
    {
        public static IServiceCollection RegisteredServices(this IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            services.AddDbContext<AppDbContext>(options => {
                options.UseInMemoryDatabase("supermarket-api-in-memory");
            });

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<IProductService, ProductService>();
            return services;
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SimpleRestfulApi.Domain.Repositories;
using SimpleRestfulApi.Domain.Services;
using SimpleRestfulApi.Persistence.Contexts;
using SimpleRestfulApi.Persistence.Repositories;
using SimpleRestfulApi.Services;

namespace SimpleRestfulApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // Config database
            builder.Services.AddDbContext<AppDbContext>(options => {
                options.UseInMemoryDatabase("supermarket-api-in-memory");
            });

            // Dependency injection
            builder.Services.AddScoped<ICategoryRespository, CategoryRepository>();
            builder.Services.AddScoped<ICategoryService, CategoryService>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }


            app.UseAuthorization();


            app.MapControllers();

            // Seed in memory data
            using(var scope = app.Services.CreateScope())
            using(var context = scope.ServiceProvider.GetService<AppDbContext>())
            {
                context.Database.EnsureCreated();
            }

            app.Run();
        }
    }
}
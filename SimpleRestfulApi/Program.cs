using Microsoft.EntityFrameworkCore;
using SimpleRestfulApi.Domain.Repositories;
using SimpleRestfulApi.Domain.Services;
using SimpleRestfulApi.Persistence.Contexts;
using SimpleRestfulApi.Persistence.Repositories;
using SimpleRestfulApi.Services;
using SimpleRestfulApi.Startup;

namespace SimpleRestfulApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.RegisteredServices();
            var app = builder.Build();

            app.ConfigureSwagger();
            app.UseAuthorization();
            app.MapControllers();
            app.SeedData();

            app.Run();
        }
    }
}
using SimpleRestfulApi.Persistence.Contexts;

namespace SimpleRestfulApi.Startup
{
    public static class DatabaseSeeder
    {
        public static WebApplication SeedData(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            using (var context = scope.ServiceProvider.GetService<AppDbContext>())
            {
                context.Database.EnsureCreated();
            }
            return app;
        }
    }
}

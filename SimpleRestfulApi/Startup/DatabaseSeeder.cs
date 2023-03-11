using Microsoft.Extensions.Hosting;
using SimpleRestfulApi.Persistence.Contexts;

namespace SimpleRestfulApi.Startup
{
    public static class DatabaseSeeder
    {
        public static async Task<WebApplication> InitData(this WebApplication app)
        {
            using var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;
            try
            {
                var context = services.GetRequiredService<AppDbContext>();
                await SeedData.Seed(context);
            }
            catch (Exception ex)
            {
                var logger = services.GetRequiredService<ILogger<Program>>();
                logger.LogError(ex, "An error occured during Seeding Data");
            }
            return app;
        }
    }
}

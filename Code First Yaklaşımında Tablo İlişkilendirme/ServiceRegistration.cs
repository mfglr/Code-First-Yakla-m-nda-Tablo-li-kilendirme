using Code_First_Yaklaşımında_Tablo_İlişkilendirme.Context;
using Microsoft.EntityFrameworkCore;

namespace Code_First_Yaklaşımında_Tablo_İlişkilendirme
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddContext(this IServiceCollection services)
        {
            var configuration = services.BuildServiceProvider().GetRequiredService<IConfiguration>();
            var connectionString = configuration.GetConnectionString("SqlServer");
            return services
               .AddDbContext<PatikaSecondDbContext>(x => x.UseSqlServer(connectionString));
        }

        public static IServiceCollection InitializeDb(this IServiceCollection services)
        {
            using var scope = services.BuildServiceProvider().CreateScope();
            using var context = scope.ServiceProvider.GetRequiredService<PatikaSecondDbContext>();
            context.Database.Migrate();

            return services;
        }

    }
}

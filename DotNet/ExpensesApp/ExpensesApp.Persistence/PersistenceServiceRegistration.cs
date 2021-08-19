using ExpensesApp.Application.Contracts.Persistence;
using ExpensesApp.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExpensesApp.Persistence
{
    public static class PersistenceServiceRegistration
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ExpensesAppDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("ExpensesAppConnectionString")));

            services.AddScoped(typeof(IAsyncRepository<>), typeof(BaseRepository<>));
            services.AddScoped<IClientRolesRepository, ClientRoleRepository>();

            return services;
        }
    }
}

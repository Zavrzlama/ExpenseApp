using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ExpensesApp.Application
{
    public static class ApplicationServicesRegistration
    {
        public static IServiceCollection AddApllicationServices(this IServiceCollection services)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddMediatR(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
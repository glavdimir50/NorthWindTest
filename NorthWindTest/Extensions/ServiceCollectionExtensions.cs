using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using NorthWindTest.DataAccess.Classes;
using NorthWindTest.DataAccess.Interfaces;
using NorthWindTest.Entity.Entity;

namespace NorthWindTest.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddService(this IServiceCollection services, IWebHostEnvironment env)
        {
            //todo:addService()
            #region CustomersDBService
            services.AddScoped<ICustomerDbService, CustomerDbService>();
            services.AddScoped<IGenericRepository<Customers>, GenericRepository<Customers>>();
            #endregion

            return services;
        }
    }
}

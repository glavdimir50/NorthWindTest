using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using NorthWindTest.Business.MainBusiness.Classes;
using NorthWindTest.Business.MainBusiness.Interfaces;
using NorthWindTest.DataAccess.Classes;
using NorthWindTest.DataAccess.Interfaces;
using NorthWindTest.Entity.Entity;

namespace NorthWindTest.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddService(this IServiceCollection services, IWebHostEnvironment env)
        {
            #region CustomersDBService
            services.AddScoped<ICustomerDbService, CustomerDbService>();
            services.AddScoped<IGenericRepository<Customers>, GenericRepository<Customers>>();
            #endregion

            #region Home
            services.AddTransient<ICustomerService, CustomerService>();
            #endregion
            return services;
        }
    }
}

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace NorthWindTest.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddService(this IServiceCollection services, IWebHostEnvironment env)
        {
            //todo:addService()
            return services;
        }
    }
}

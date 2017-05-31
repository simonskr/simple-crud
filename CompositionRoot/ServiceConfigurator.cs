using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using SimpleCrud.DAL;
using SimpleCrud.BLL.Abstract;
using SimpleCrud.BLL;

namespace CompositionRoot
{
    public static class ServiceConfigurator
    {
        public static void Compose(this IServiceCollection services, 
            IConfigurationRoot configuration)
        {
            services.AddEntityFrameworkDbContext(configuration["ConnectionString"]);

            services.AddTransient<ICustomerRepository, EFCustomerRepository>();
            services.AddTransient<ICustomerService, CustomerService>();
        }
    }
}

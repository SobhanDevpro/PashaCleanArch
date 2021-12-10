using Microsoft.Extensions.DependencyInjection;
using PashaMarket.Application.Services.Implementations;
using PashaMarket.Application.Services.Interfaces;
using PashaMarket.Data.Repositories;
using PashaMarket.Domain.IRepositories;

namespace PashaMarket.Ioc
{
    public class DependencyContainer
    {
        public static void ConfigureServiceCollection(IServiceCollection services)
        {
            // repository dependencies
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<ISiteRepository, SiteRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            // service dependencies
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPasswordHelper, PasswordHelper>();
            services.AddScoped<ISiteService, SiteService>();
            services.AddScoped<IProductService, ProductService>();


        }
    }
}

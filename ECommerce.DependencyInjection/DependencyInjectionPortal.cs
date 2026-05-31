using ECommerce.Application.Interface.Repository;
using ECommerce.Application.Interfaces.services;
using ECommerce.Application.Mapping;
using ECommerce.Application.Service;
using ECommerce.Infrastructure.Data;
using ECommerce.Infrastructure.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ECommerce.DependencyInjection;

public static class DependencyInjectionPortal
{
    public static IServiceCollection AddECommerceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();

        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IProductService, ProductService>();


        services.AddAutoMapper(typeof(CategoryProfile).Assembly);

        return services;
    }
}
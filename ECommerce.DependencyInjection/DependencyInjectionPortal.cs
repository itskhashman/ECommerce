using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using ECommerce.Infrastructure.Data;
using ECommerce.Infrastructure.Repository;
using ECommerce.Infrastructure.Identity;
using ECommerce.Application.Interface.Service;
using ECommerce.Application.Interface.Repository;
using ECommerce.Application.Interfaces.services;
using ECommerce.Application.Service;
using ECommerce.Application.Mapping;
using ECommerce.Application.Interfaces;

namespace ECommerce.DependencyInjection;

public static class DependencyInjectionPortal
{
    public static IServiceCollection AddECommerceServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

        services.AddIdentity<ApplicationUser, IdentityRole<int>>(options =>
        {
            options.Password.RequireDigit = true;
            options.Password.RequiredLength = 8;
            options.User.RequireUniqueEmail = true;
        })
        .AddEntityFrameworkStores<ApplicationDbContext>()
        .AddClaimsPrincipalFactory<CustomUserClaimsPrincipalFactory>();

        services.ConfigureApplicationCookie(options =>
        {
            options.LoginPath = "/Account/Login";
            options.LogoutPath = "/Account/Login";
        });

        services.AddScoped<IIdentityService, IdentityService>();
        services.AddScoped<IUserRepository, UserRepository>();

        services.AddScoped<ICategoryRepository, CategoryRepository>();
        services.AddScoped<IProductRepository, ProductRepository>();
        services.AddScoped<IWishlistRepository, WishlistRepository>();

        services.AddScoped<ICategoryService, CategoryService>();
        services.AddScoped<IProductService, ProductService>();
        services.AddScoped<IHomeService, HomeService>();
        services.AddScoped<ISearchService, SearchService>();
        services.AddScoped<IWishlistService, WishlistService>();

        services.AddAutoMapper(typeof(CategoryProfile).Assembly);

        services.AddHttpContextAccessor();

        return services;
    }
}
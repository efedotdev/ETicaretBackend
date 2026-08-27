using Microsoft.EntityFrameworkCore;
using ETicaret.Apı.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ETicaret.Apı.Persistence.Repositories.Basket;
using ETicaret.Apı.Persistence.Repositories.BasketItem;
using ETicaret.Apı.Persistence.Repositories.CompletedOrder;
using ETicaretApı.Application.Repositories;
using ETicaretApı.Persistence.Repositories;
using ETicaretApı.Domain.Entities.Identity;
using ETicaretApı.Persistence.Services;
using ETicaretApı.Application.Abstractions.Services;
using ETicaretApı.Application.Abstractions.Services.Authentications;
using ETicaretApı.Application.CustomerRepo;
using ETicaretApı.Application.OrderRepo;
using ETicaretApı.Application.ProductRepo;
using ETicaretApı.Application.Repositories.Basket;
using ETicaretApı.Application.Repositories.BasketItem;
using ETicaretApı.Application.Repositories.CompletedOrder;
using ETicaretApı.Application.Repositories.Endpoint;
using ETicaretApı.Application.Repositories.File;
using ETicaretApı.Application.Repositories.InvoiceFile;
using ETicaretApı.Application.Repositories.ProductImageFile;
using ETicaretApı.Infrasturacture.Repositories.File;
using ETicaretApı.Infrasturacture.Repositories.InvoiceFile;
using ETicaretApı.Infrasturacture.Repositories.ProductImageFile;
using Microsoft.AspNetCore.Identity;

namespace ETicaret.Apı.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddDbContext<ETicaretAPIDbContext>(options => options.UseNpgsql(Configuration.ConnectionString));
        services.AddIdentity<AppUser, AppRole>(options =>
        {
            options.Password.RequiredLength = 3;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireUppercase = false;
        }).AddEntityFrameworkStores<ETicaretAPIDbContext>()
        .AddDefaultTokenProviders();


        services.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
        services.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
        services.AddScoped<IOrderReadRepository, OrderReadRepository>();
        services.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
        services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
        services.AddScoped<IProductReadRepository, ProductReadRepository>();
        services.AddScoped<IFileReadRepository, FileReadRepository>();
        services.AddScoped<IFileWriteRepository, FileWriteRepository>();
        services.AddScoped<IProductImageFileReadRepository, ProductImageFileReadRepository>();
        services.AddScoped<IProductImageFileWriteRepository, ProductImageFileWriteRepository>();
        services.AddScoped<IInvoiceFileReadRepository, InvoiceFileReadRepository>();
        services.AddScoped<IInvoiceFileWriteRepository, InvoiceFileWriteRepository>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IAuthService, AuthService>();
        services.AddScoped<IExternalAuthentication, AuthService>();
        services.AddScoped<IInternalAuthentication, AuthService>();
        services.AddScoped<IBasketItemReadRepository, BasketItemReadRepository>();
        services.AddScoped<IBasketItemWriteRepository, BasketItemWriteRepository>();
        services.AddScoped<IBasketReadRepository, BasketReadRepository>();
        services.AddScoped<IBasketWriteRepository, BasketWriteRepository>();
        services.AddScoped<IBasketService, BasketService>();
        services.AddScoped<IOrderService, OrderService>();
        services.AddScoped<ICompletedOrderReadRepository, CompletedOrderReadRepository>();
        services.AddScoped<ICompletedOrderWriteRepository, CompletedOrderWriteRepository>();
        services.AddScoped<IEndpointReadRepository, EndpointReadRepository>();
        services.AddScoped<IEndpointWriteRepository, EndpointWriteRepository>();
        services.AddScoped<IMenuReadRepository, MenuReadRepository>();
        services.AddScoped<IMenuWriteRepository, MenuWriteRepository>();
        services.AddScoped<IRoleService, RoleService>();
        services.AddScoped<IAuthorizationEndpointService, AuthorizationEndpointService>();
        services.AddScoped<IProductService, ProductService>();


    }
}
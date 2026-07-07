using ETicaret.Apı.Persistence.Concretes;
using ETicaretApı.Application.Abstractions;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaret.Apı.Persistence;

public static class ServiceRegistration
{
    public static void AddPersistenceServices(this IServiceCollection services)
    {
        services.AddSingleton<IProductService, ProductService>();

    }
}
using ETicaretAPI.Infrastructure.Services;
using ETicaretAPI.Infrastructure.Services.Configurations;
using ETicaretApı.Application.Abstractions.Services;
using ETicaretApı.Application.Abstractions.Services.Configurations;
using ETicaretApı.Application.Abstractions.Storage;
using ETicaretApı.Infrastructure.Services;
using ETicaretApı.Infrastructure.Services.Storage;
using ETicaretApı.Infrastructure.Services.Storage.Azure;
using ETicaretApı.Infrastructure.Services.Storage.Local;
using ETicaretApı.Infrastructure.Services.Token;
using ETicaretApı.Application.Abstractions.Token;
using ETicaretApı.Application.Services;
using ETicaretApı.Infrasturacture.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretApı.Infrasturacture;

public static class ServiceRegistration
{
    public static void AddInfrastructureServices(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IStorageService, StorageService>();
        serviceCollection.AddScoped<IFileService, FileService>();
        serviceCollection.AddScoped<ITokenHandler, TokenHandler>();
        serviceCollection.AddScoped<IMailService, MailService>();
        serviceCollection.AddScoped<IApplicationService, ApplicationService>();
        serviceCollection.AddScoped<IQRCodeService, QRCodeService>();
    }

    public static void AddStorage<T>(this IServiceCollection serviceCollection) where T : class, IStorage
    {
        serviceCollection.AddScoped<IStorage, T>();
    }

    public static void AddStorage(this IServiceCollection serviceCollection, StorageType storageType)
    {
        switch (storageType)
        {
            case StorageType.Local:
                serviceCollection.AddScoped<IStorage, LocalStorage>();
                break;
            case StorageType.Azure:
                serviceCollection.AddScoped<IStorage, AzureStorage>();
                break;
            case StorageType.AWS:

                break;
            default:
                serviceCollection.AddScoped<IStorage, LocalStorage>();
                break;
        }
    }
}
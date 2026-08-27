using ETicaretApı.Application.Abstractions.Services.Hubs;
using ETicaretApı.SignalR.HubServices;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace ETicaretApı.SignalR;

public static class ServiceRegistration
{
    public static void AddSignalRServices(this IServiceCollection collection)
    {
        collection.AddTransient<IProductHubService, ProductHubService>();
        collection.AddTransient<IOrderHubService, OrderHubService>();
        collection.AddSignalR();
    }
}
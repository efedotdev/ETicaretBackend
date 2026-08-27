using ETicaretApı.Application.Abstractions.Services.Hubs;
using ETicaretApı.SignalR.Hubs;
using Microsoft.AspNetCore.SignalR;

namespace ETicaretApı.SignalR.HubServices;

public class ProductHubService : IProductHubService
{
    readonly  IHubContext<ProductHub> _hubContext;

    public ProductHubService(IHubContext<ProductHub> hubContext)
    {
        _hubContext = hubContext;
    }

    public async Task ProductAddedMessageAsync(string message)
    {
        await _hubContext.Clients.All.SendAsync(ReceiveFunctionNames.ProductAddedMessage, message);
    }
}
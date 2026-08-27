namespace ETicaretApı.Application.Abstractions.Services.Hubs;

public interface IOrderHubService
{
    Task OrderAddedMessageAsync(string message);
}
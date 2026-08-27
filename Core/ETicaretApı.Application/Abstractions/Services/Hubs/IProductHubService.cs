namespace ETicaretApı.Application.Abstractions.Services.Hubs;

public interface IProductHubService
{
   Task ProductAddedMessageAsync(string message);
}
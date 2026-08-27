using ETicaretApı.Application.DTOs.Configuration;

namespace ETicaretApı.Application.Abstractions.Services.Configurations;

public interface IApplicationService
{
    List<Menu> GetAuthorizeDefinitionEndpoints(Type type);
}
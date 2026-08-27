using MediatR;

namespace ETicaretApı.Application.Cqrs.Commands.AppUser.RefreshTokenLogin;

public class RefreshTokenLoginCommandRequest : IRequest<RefreshTokenLoginCommandResponse>
{
    public string RefreshToken { get; set; }
}
using ETicaretApı.Application.Cqrs.Commands.AppUser.FacebookLogin;
using MediatR;

namespace ETicaretApı.Application.Cqrs.Commands.AppUser.FacebookLogin;

public class FacebookLoginCommandRequest : IRequest<FacebookLoginCommandResponse>
{
    public string AuthToken { get; set; }
}
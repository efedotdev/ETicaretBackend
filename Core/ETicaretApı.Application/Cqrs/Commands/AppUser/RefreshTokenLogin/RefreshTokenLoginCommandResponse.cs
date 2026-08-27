using ETicaretApı.Application.DTOs;

namespace ETicaretApı.Application.Cqrs.Commands.AppUser.RefreshTokenLogin;

public class RefreshTokenLoginCommandResponse
{
    public Token Token { get; set; }
}
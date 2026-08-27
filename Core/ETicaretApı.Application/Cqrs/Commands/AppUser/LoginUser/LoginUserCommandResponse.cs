using ETicaretApı.Application.DTOs;

namespace ETicaretApı.Application.Cqrs.Commands.AppUser.LoginUser;

public class LoginUserCommandResponse
{
}
public class LoginUserSuccessCommandResponse : LoginUserCommandResponse
{
    public Token Token { get; set; }
}
public class LoginUserErrorCommandResponse : LoginUserCommandResponse
{
    public string Message { get; set; }
}
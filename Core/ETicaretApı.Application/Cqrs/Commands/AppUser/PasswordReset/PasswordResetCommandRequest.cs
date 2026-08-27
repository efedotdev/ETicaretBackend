using MediatR;

namespace ETicaretApı.Application.Cqrs.Commands.AppUser.PasswordReset;

public class PasswordResetCommandRequest : IRequest<PasswordResetCommandResponse>
{
    public string Email { get; set; }
}
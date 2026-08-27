using MediatR;

namespace ETicaretApı.Application.Cqrs.Commands.AppUser.AssignRoleToUser;

public class AssignRoleToUserCommandRequest : IRequest<AssignRoleToUserCommandResponse>
{
    public string UserId { get; set; }
    public string[] Roles { get; set; }
}
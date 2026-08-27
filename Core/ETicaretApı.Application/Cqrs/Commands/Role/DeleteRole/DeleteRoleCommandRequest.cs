using MediatR;

namespace ETicaretApı.Application.Cqrs.Commands.Role.DeleteRole;

public class DeleteRoleCommandRequest : IRequest<DeleteRoleCommandResponse>
{
    public string Id { get; set; }
}
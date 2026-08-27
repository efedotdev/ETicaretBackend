using MediatR;

namespace ETicaretApı.Application.Cqrs.Commands.Role.CreateRole;

public class CreateRoleCommandRequest : IRequest<CreateRoleCommandResponse>
{
    public string Name { get; set; }
}